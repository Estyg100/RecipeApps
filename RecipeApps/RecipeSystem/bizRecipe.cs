using System;

namespace RecipeSystem
{
    public class bizRecipe : bizObject
    {
        public bizRecipe()
        {

        }
        
        private int _recipeid;
        private int _usersid;
        private int _cuisineid;
        private string _recipename = "";
        private int _caloriesperserving;
        private DateTime _datedraft;
        private DateTime? _datepublished;
        private DateTime? _datearchived;
        private string _currentstatus;

        public int RecipeId
        {
            get { return _recipeid; }
            set
            {
                if (_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int UsersId
        {
            get { return _usersid; }
            set
            {
                if (_usersid != value)
                {
                    _usersid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CuisineId
        {
            get { return _cuisineid; }
            set
            {
                if (_cuisineid != value)
                {
                    _cuisineid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeName
        {
            get { return _recipename; }
            set
            {
                if (_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CaloriesPerServing
        {
            get { return _caloriesperserving; }
            set
            {
                if (_caloriesperserving != value)
                {
                    _caloriesperserving = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateDraft
        {
            get { return _datedraft; }
            set
            {
                if (_datedraft != value)
                {
                    _datedraft = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DatePublished
        {
            get { return _datepublished; }
            set
            {
                if (_datepublished != value)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DateArchived
        {
            get { return _datearchived; }
            set
            {
                if (_datearchived != value)
                {
                    _datearchived = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
