﻿using common.portal.com.Entity;

namespace common.portal.com.Interface
{
    public interface IStarbucksService
    {
        Customer? SaveToDb(Customer customer);
    }
}
