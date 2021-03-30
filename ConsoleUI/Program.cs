using Business.Concrete;
using Business.Constants;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager1 = new CarManager(new EfCarDal());
            ColorManager colorManager1 = new ColorManager(new EfColorDal());
            BrandManager brandManager1 = new BrandManager(new EfBrandDal());
            RentalManager rentalManager1 = new RentalManager(new EfRentalDal());
            
            //AddRentalTest(rentalManager1);

            //GetAllCarTest(carManager1);
            //DeleteCarTest(carManager1);
            //GetBrandIdCarTest(carManager1);
            //GetColorIdCatTest(carManager1);
            //UpdateCarTest(carManager1);
            //AddCarTest(carManager1);

            //AddColorTest(colorManager1);
            //UpdateColorTest(colorManager1);
            //DeleteColorTest(colorManager1);
            //GetAllColorTest(colorManager1);

            //AddBrandTest(brandManager1);
            //UpdateBrandTest(brandManager1);
            //DeleteBrandTest(brandManager1);
            //GetAllBrandTest(brandManager1);

            //GetCarDetailTest(carManager1);


        }

        private static void AddRentalTest(RentalManager rentalManager1)
        {
            rentalManager1.Add(new Rental
            {
                CarId = 2,
                CustomerId = 2,
                RentDate = "05/03/2021",
                ReturnDate = "28/03/2021"
            });
            foreach (var rental in rentalManager1.GetAll().Data)
            {
                Console.WriteLine(rental.CarId + " id li arac");
            }
        }

        private static void GetCarDetailTest(CarManager carManager1)
        {
            foreach (var car in carManager1.GetCarDetails().Data)
            {
                Console.WriteLine("Araba adı: " + car.CarName + "||| Marka: " + car.BrandName + "||| Fiyat: " + car.DailyPrice);

            }
        }

        private static void GetAllBrandTest(BrandManager brandManager1)
        {
            foreach (var brand in brandManager1.GetAll().Data)
            {
                Console.WriteLine("Id: " + brand.Id + " Marka: " + brand.BrandName);
            }
        }

        private static void DeleteBrandTest(BrandManager brandManager1)
        {
            brandManager1.Delete(new Brand { Id = 6, BrandName = "Skoda" });
            foreach (var brand in brandManager1.GetAll().Data)
            {
                Console.WriteLine("Id: " + brand.Id + " Marka: " + brand.BrandName);
            }
        }

        private static void UpdateBrandTest(BrandManager brandManager1)
        {
            brandManager1.Update(new Brand { Id = 6, BrandName = "Jaguar" });
            foreach (var brand in brandManager1.GetAll().Data)
            {
                Console.WriteLine("Id: " + brand.Id + " Marka: " + brand.BrandName);
            }
        }

        private static void AddBrandTest(BrandManager brandManager1)
        {
            brandManager1.Add(new Brand { Id = 6, BrandName = "Skoda" });
            foreach (var brand in brandManager1.GetAll().Data)
            {
                Console.WriteLine("Id: " + brand.Id + " Marka: " + brand.BrandName);
            }
        }

        private static void GetAllColorTest(ColorManager colorManager1)
        {
            foreach (var color in colorManager1.GetAll().Data)
            {
                Console.WriteLine("Boya rengi: " + color.ColorName);
            }
        }

        private static void DeleteColorTest(ColorManager colorManager1)
        {
            colorManager1.Delete(new Color { Id = 4, ColorName = "Pembe" });
            foreach (var color in colorManager1.GetAll().Data)
            {
                Console.WriteLine("Boya rengi: " + color.ColorName);
            }
        }

        private static void UpdateColorTest(ColorManager colorManager1)
        {
            colorManager1.Update(new Color { Id = 3, ColorName = "Kırmızı" });
            foreach (var color in colorManager1.GetAll().Data)
            {
                Console.WriteLine("Boya rengi: " + color.ColorName);
            }
        }

        private static void AddColorTest(ColorManager colorManager1)
        {
            colorManager1.Add(new Color { Id = 2, ColorName = "Mavi" });
            foreach (var color in colorManager1.GetAll().Data)
            {
                Console.WriteLine("Boya rengi: " + color.ColorName);
            }
        }

        private static void AddCarTest(CarManager carManager1)
        {
            carManager1.Add(new Car { CarName = "Camaro", BrandId = 5, ColorId = 3, ModelYear = "2018", DailyPrice = 750000, Description = "Sıfır" });
            foreach (var car in carManager1.GetAll().Data)
            {
                Console.WriteLine(car.Id + " Araba adı: " + car.CarName + " Yılı: " + car.ModelYear + " Fiyat: " + car.DailyPrice + " Acıklama: " + car.Description);

            }
        }

        private static void UpdateCarTest(CarManager carManager1)
        {
            carManager1.Update(new Car { Id = 2010, CarName = "Wolksvagen", BrandId = 4, ColorId = 1, ModelYear = "1998", DailyPrice = 140000, Description = "Hatasiz Boyasiz" });
            foreach (var car in carManager1.GetAll().Data)
            {
                Console.WriteLine(car.Id + " Araba adı: " + car.CarName + " Yılı: " + car.ModelYear + " Fiyat: " + car.DailyPrice + " Acıklama: " + car.Description);

            }
        }

        private static void GetColorIdCatTest(CarManager carManager1)
        {
            foreach (var car in carManager1.GetCarsColorId(2).Data)
            {
                Console.WriteLine("ColorId: " + car.ColorId + " Araba Model Yılı: " + car.ModelYear + " Fiyat: " + car.DailyPrice + " Acıklama: " + car.Description);

            }
        }

        private static void GetBrandIdCarTest(CarManager carManager1)
        {
            foreach (var car in carManager1.GetCarsBrandId(1).Data)
            {
                Console.WriteLine("BrandId: " + car.BrandId + " Araba Model Yılı: " + car.ModelYear + " Fiyat: " + car.DailyPrice + " Acıklama: " + car.Description);

            }
        }

        private static void DeleteCarTest(CarManager carManager1)
        {
            carManager1.Delete(new Car { Id = 2009, CarName = "Wolksvagen", BrandId = 4, ColorId = 1, ModelYear = "1998", DailyPrice = 150000, Description = "Hatasiz Boyasiz" });
            foreach (var car in carManager1.GetAll().Data)
            {
                Console.WriteLine(car.Id + "Araba adı: " + car.CarName + " Yılı: " + car.ModelYear + " Fiyat: " + car.DailyPrice + " Acıklama: " + car.Description);

            }
        }

        private static void GetAllCarTest(CarManager carManager1)
        {
            foreach (var car in carManager1.GetAll().Data)
            {
                Console.WriteLine("Araba adı: " + car.CarName + " Yılı: " + car.ModelYear + " Fiyat: " + car.DailyPrice + " Acıklama: " + car.Description);

            }
        }
    }
}
