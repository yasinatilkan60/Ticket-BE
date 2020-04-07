using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class JourneyManager : IJourneyService
    {
        private IJourneyDal _journeyDal;
        public JourneyManager(IJourneyDal journeyDal)
        {
            _journeyDal = journeyDal;
        }
        public IDataResult<List<Journey>> GetListByJourneyDate(DateTime journeyDate, string station, string destination)
        {
            return new SuccessDataResult<List<Journey>>(_journeyDal.GetList(j => j.JourneyDate == journeyDate && j.Station==station && j.Destination== destination ).ToList());
        }
    }
}
