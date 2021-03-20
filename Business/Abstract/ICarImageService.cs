﻿using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetAllByCarId(int carId);
        IDataResult<CarImage> GetById(int id);
        IResult Add(IFormFile image, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile image, CarImage carImage);
    }
    //public interface ICarImageService
    //{
    //    IResult Add(IFormFile file, CarImage carImage);
    //    IResult Delete(CarImage carImage);
    //    IResult Update(IFormFile file, CarImage carImage);
    //    IDataResult<CarImage> Get(int id);
    //    IDataResult<List<CarImage>> GetAll();
    //    IDataResult<List<CarImage>> GetImagesByCarId(int id);
    //}
}
