namespace SingletonDesignPattern
{
	public class ThreadSafeSingleton
	{
		private static ThreadSafeSingleton instance;
		private static readonly object lockObject = new object();

		//Private constructior prevents instantiation from outsite the class.
		private ThreadSafeSingleton()
		{
		}

		public static ThreadSafeSingleton Instance
		{
			get
			{
				//Double-Check locking for thread safety.
				if (instance == null)
				{
					lock (lockObject)
					{
						instance ??= new ThreadSafeSingleton();
					}
				}
				return instance;
			}
		}
	}
}
