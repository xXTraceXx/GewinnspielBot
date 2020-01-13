using GewinnspielBot.Interfaces;
using GewinnspielBot.Exceptions;

namespace GewinnspielBot
{
    public class Overview
    {
        public IDbController DbController { get; set; }

        public Overview(IDbController dbController)
        {
            this.DbController = dbController;
        }

        public void ShowAll()
        {
            if (DbController == null)
                throw new EmptyPropertyException($"The Property {nameof(this.DbController)} is null or empty");

            this.DbController.ShowAll();
        }

        public void ShowUnsolved()
        {
            if (DbController == null)
                throw new EmptyPropertyException($"The Property {nameof(this.DbController)} is null or empty");

            this.DbController.ShowUnsolved();
        }

        public void ShowSolved()
        {
            if (DbController == null)
                throw new EmptyPropertyException($"The Property {nameof(this.DbController)} is null or empty");

            this.DbController.ShowSolved();
        }
    }
}
