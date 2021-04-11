using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCreditCardDal : EfEntityRepositoryBase<CreditCard, CarRentalContext>,ICreditCardDal
    {
        public List<CreditCardDetailDto> GetCreditCardDetails(Expression<Func<CreditCard, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from card in filter == null ? context.CreditCards : context.CreditCards.Where(filter)
                             join customer in context.Customers
                             on card.CustomerId equals customer.Id

                             select new CreditCardDetailDto
                             {
                                 CreditCardId = card.CardId,
                                 CustomerId = customer.Id,
                                 CardCvv = card.CardCvv,
                                 CardNumber = card.CardNumber,
                                 MoneyInTheCard = card.MoneyInTheCard,
                                 NameOnTheCard = card.NameOnTheCard,
                                 ExpirationDate = card.ExpirationDate
                             };
                return result.ToList();

            }
        }
    }
}
