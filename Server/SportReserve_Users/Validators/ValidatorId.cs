﻿using SportReserveServer.Exceptions;
using SportReserveServer.Interfaces;

namespace SportReserveServer.Validators
{
    public class ValidatorId : IValidatorId
    {
        public void ValidateId(int id)
        {
            if(id <= 0)
            {
                throw new BadRequestException("Id value should be greater than 0.");
            }
        }
    }
}
