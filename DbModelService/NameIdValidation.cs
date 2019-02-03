using System;
using System.Collections.Generic;
using System.Text;

namespace DbModelService
{
    public class NameIdValidation
    {
        DataCollectionClass DCCObjectforIDandNameValidation;
        public NameIdValidation()
        {
            DCCObjectforIDandNameValidation = new DataCollectionClass();
        }

        public void CheckForExistingId(int MovieIdForCheck)
        {
            foreach(var TempVarForMovie in DCCObjectforIDandNameValidation.moviesCollection)
            {
                if(TempVarForMovie.MovieId==MovieIdForCheck)
                {
                    throw new CustomException("This Id is already present in the database. Please use another Id");
                    
                }
            }
        }

        public void IsValidName(string MovieName)
        {
            if(MovieName=="")
            {
                throw new CustomException("Enter the name of movie.");
            }
        }

        public void CheckIfIdNotExist(int MovieIdIfNotExist)
        {
            int FlagForIdCheck = 0;
            foreach (var TempVarForMovie in DCCObjectforIDandNameValidation.moviesCollection)
            {
                if (TempVarForMovie.MovieId == MovieIdIfNotExist)
                {
                    FlagForIdCheck = 1;
                }
            }
            if(FlagForIdCheck==0)
            {
                throw new CustomException("Inavalid ID Exception. Enter valid ID to update.");
            }
        }
    }
}
