using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        IResult Add(CreditCard creditCard);
        IResult Delete(CreditCard creditCard);
        IResult Update(CreditCard creditCard);
        IDataResult<List<CreditCard>> GetAll();
        IResult VerifyCard(CreditCard creditCard);
        IDataResult<List<CreditCard>> GetByCardNumber(string cardNumber);

        //IDataResult<CreditCard> GetById(int id);
        //IDataResult<List<CreditCard>> GetByCardNumber(string cardNumber);
        IResult IsCardExist(CreditCard creditCard);
    }
}