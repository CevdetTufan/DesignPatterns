namespace SingletonDesignPattern
{
	public class Singleton
	{
		private static Singleton instance;

		//Private constructior prevents instantiation from outsite the class.
		private Singleton()
		{
		}

		public static Singleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Singleton();
				}
				return instance;
			}
		}
	}
}
