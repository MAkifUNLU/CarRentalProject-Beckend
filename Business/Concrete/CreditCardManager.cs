using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }
        public IResult Add(CreditCard creditCard)
        {
            var result = CheckCreditCard(creditCard);

            if (result)
            {
                return new SuccessResult();
            }

            _creditCardDal.Add(creditCard);
            return new SuccessResult(Messages.CreditCardAdded);
        }

        public IResult Delete(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult(Messages.CreditCardDeleted);
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll());
        }
        public IDataResult<List<CreditCard>> GetCardsByCustomerId(int customerId)
        {
            var result = _creditCardDal.GetAll(card => card.CustomerId == customerId);
            return new SuccessDataResult<List<CreditCard>>(result);
        }

        public IDataResult<List<CreditCard>> GetByCardNumber(string cardNumber)
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(c => c.CardNumber == cardNumber));
        }

        public IResult Update(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
            return new SuccessResult(Messages.CreditCardUpdated);
        }

        public IResult VerifyCard(CreditCard creditCard)
        {
            var result = _creditCardDal.Get(c => c.NameOnTheCard == creditCard.NameOnTheCard && c.CardNumber == creditCard.CardNumber && c.CardCvv == creditCard.CardCvv);
            if (result == null)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
        public IResult IsCardExist(CreditCard creditCardDal)
        {
            var result = _creditCardDal.Get(c =>
                c.NameOnTheCard == creditCardDal.NameOnTheCard && c.CardNumber == creditCardDal.CardNumber &&
                c.CardCvv == creditCardDal.CardCvv);
            if (result == null)
            {
                return new ErrorResult();
            }

            return new SuccessResult();
        }
        private bool CheckCreditCard(CreditCard card)
        {
            var beforeExist = _creditCardDal.GetAll(c => c.CustomerId == card.CustomerId);

            if (beforeExist.Count > 0)
            {
                var currentCard = _creditCardDal.Get(c => c.CardNumber == card.CardNumber);

                if (currentCard != null)
                {
                    return true;
                }
            }

            return false;
        }
        //public IResult Add(CreditCard fakeCard)
        //{
        //    _creditCardDal.Add(fakeCard);
        //    return new SuccessResult();
        //}

        //public IResult Delete(CreditCard creditCardDal)
        //{
        //    _creditCardDal.Delete(creditCardDal);
        //    return new SuccessResult();
        //}

        //public IDataResult<List<CreditCard>> GetAll()
        //{
        //    return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll());
        //}

        //public IDataResult<CreditCard> GetById(int id)
        //{
        //    return new SuccessDataResult<CreditCard>(_creditCardDal.Get(c => c.Id == id));
        //}

        //public IDataResult<List<CreditCard>> GetByCardNumber(string cardNumber)
        //{
        //    return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(c => c.CardNumber == cardNumber));
        //}

        //public IResult Update(CreditCard fakeCard)
        //{
        //    _creditCardDal.Update(fakeCard);
        //    return new SuccessResult();
        //}
    }
}