using _3sem_oblikatorisk_opgave_1;
using System.Security.Cryptography.X509Certificates;

namespace CarsRestApi.Repo
{
    public class CarsRepo
    {

        private int NextId = 1;

        private List<Car> CarCollection;

        public CarsRepo()
        {

            CarCollection = new List<Car>()
            {
                new Car() { Id= NextId++, LicensePlate="5ds32", Model="BMW", Price=300000 },
                new Car() { Id= NextId++, LicensePlate="fsd56", Model="AUDI", Price=250000},
                new Car() { Id= NextId++, LicensePlate="ds3as", Model="HONDA", Price=100000},
                new Car() { Id= NextId++, LicensePlate="64gds", Model="VOLVO", Price=120000 },

                 

            };

        }
       public List<Car> GetAll()
        {
            List<Car> result = new List<Car>(CarCollection);
            return result;

        }

        public Car GetById(int id)
        {
            //Car car = CarCollection[id]; 
            //return car;
            var cid = CarCollection.Find(x => x.Id == id);
            return cid;
        }
        public Car Delete(int id)
        {
            var cid = GetById(id);
            if(cid != null)
            {
                CarCollection.Remove(cid);
            }
            return cid;
        }
        public Car Create(Car car)
        {
            car.Id= NextId+1;
            CarCollection.Add(car);
            return car;
        }
        public Car Update(Car car, int id)
        {
            var obj = GetById(id);
            obj.Id = car.Id;
            obj.LicensePlate = car.LicensePlate;
            obj.Price = car.Price;
            obj.Model = car.Model;

            return car;


        }
    }
}
