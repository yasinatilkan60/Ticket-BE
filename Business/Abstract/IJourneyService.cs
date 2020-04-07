using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IJourneyService
    {
        IDataResult<List<Journey>> GetListByJourneyDate(DateTime journeyDate,string station, string destination);
    }
}
