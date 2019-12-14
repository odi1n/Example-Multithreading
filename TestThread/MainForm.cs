using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TestThread
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Глобальный объект синхронизации потоков
		/// </summary>
		private readonly object pLock;
		
		/// <summary>
		/// Глобальная переменная индекса.
		/// </summary>
		private int pIndexPhotoList;
		
		/// <summary>
		/// Глобальная коллекция для хранения фотографий
		/// </summary>
		private readonly List<string> pPhotoList;
		
		public MainForm()
		{
			InitializeComponent();
			
			// Инициализируем глобальный объект синхронизации
			pLock = new object();
			
			// Инициализируем коллекцию
			pPhotoList = new List<string>();
			// Заполняем глобальную коллекцию фотографиями
			for (int i = 0; i < 100; i++)
			{
				pPhotoList.Add("фото № " + i);
			}
			
		}
		
		private void BtnStartClick(object sender, EventArgs e)
		{
			if (pPhotoList.Count <= 0)
			{
				MessageBox.Show("Не инициализирована коллекция.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			// Обнуляем глобальный индекс
			pIndexPhotoList = 0;
			
			// Очищаем лог
			TBLog.Clear();
			
			// Получаем кол-во запускаемых потоков
			int countThread = Convert.ToInt32(NumericThreadCount.Value);
			
			// Создаём массив потоков
			Thread[] threads = new Thread[countThread];
			
			// Циклом создаём потоки
			for (int i = 0; i < countThread; i++)
			{
				threads[i] = new Thread(new ThreadStart(DoThread));
				threads[i].Name = "Поток № " + i;
				threads[i].Start();
			}
		}
		
		/// <summary>
		/// Метод потока.
		/// </summary>
		private void DoThread()
		{
			Random rnd = new Random();
			
			// Получаем ID и Имя потока
			int threadId = Thread.CurrentThread.ManagedThreadId;
			string threadName = Thread.CurrentThread.Name;
			
			TBLog.Invoke((MethodInvoker)(() =>
			                               {
			             						TBLog.Text += "Запущен " + threadName + Environment.NewLine;
			                               }));
			
			string photo = string.Empty;
			
			// Создаём бесконечный цикл
			while(true)
			{
				photo = string.Empty;
				// Открываем объект синхронизации
				lock(pLock)
				{ // Код в этих скобках будет обрабатывать только один поток, остальные потоки будут ждать, пока текущий поток обработает этот код
					// Проверяем возможность взять фотографию из коллекции (Если индекс фото >= общего кол-ва фото, значит завершаем поток)
					if (pIndexPhotoList >= pPhotoList.Count)
					{
						break; // Завершаем цикл потока
					}
					// Берём фотографию из списка
					photo = pPhotoList[pIndexPhotoList];
					// Увеличиваем индекс
					pIndexPhotoList++;
				}
				
				// Псевдо загрузка фото
				TBLog.Invoke((MethodInvoker)(() =>
				                               {
			             							TBLog.Text += threadName + " загружает " + photo + Environment.NewLine;
				                               }));
				// Псевдо задержка
				Thread.Sleep(rnd.Next(100, 500));
			}
		}
	}
}
