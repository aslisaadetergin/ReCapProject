﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 )
            {
                Console.WriteLine("Araba eklendi.");
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Araba eklenemedi. Araba ismi minimum 2 karakter olmalıdır ve Araba günlük fiyatı 0'dan büyük olmalıdır.");
            }
        }

        public  List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById()
        {
            return _carDal.GetById();
        }

      
    }
}
