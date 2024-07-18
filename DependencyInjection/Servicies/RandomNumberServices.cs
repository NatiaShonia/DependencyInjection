namespace DependencyInjection.Servicies
{
    public class RandomNumberServices :IRandomNumberServices
    {
        private readonly int _randomNumber;

        public RandomNumberServices()
        {
            var random = new Random();
            _randomNumber = random.Next(1,100) ; 
        }

        public int GetNumber()
        {
            return _randomNumber;
        }

       
    }
}
