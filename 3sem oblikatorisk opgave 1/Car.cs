namespace _3sem_oblikatorisk_opgave_1
{
    public class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public int Price { get; set; }
        public string? LicensePlate { get; set; }
        public Car()
        {

        }
        public void ValidateId()
        {
            if (Id < 0)
            {
                throw new ArgumentOutOfRangeException(" Faulty Id: Id doesn't exist");
            }
        }
        public void ValidateModel()
        {
            if (Model.Length < 4)
            {
                throw new ArgumentOutOfRangeException($"The string {Model} must be at least 4 chars long. Its current length is {Model.Length}");

            }
        }
        public void ValidatePrice()
        {
            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException($"Error price cannot be negative");

            }
        }
        public void ValidateLicensePlate()
        {
            if (LicensePlate.Length <= 2 & LicensePlate.Length <= 7)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}