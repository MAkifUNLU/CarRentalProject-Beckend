using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int carId);//id buna özgü
        List<Car> GetCarsByBrandId(int brandId);//brandId
        List<Car> GetCarsByColorId(int colorId);//colorId
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}





// List<Car> GetById(int Id);
