namespace Core.Interfaces
{
    /* !AhmedShaban: Unit of work Design Pattern */
    public interface IUnitOfWork<T> where T : class
    {
        /* !AhmedShaban: Acts on a property of Type IRepository.
         * It's only getten not set.
         */

        public IGenericRepository<T> Entity { get; }

        //!AhmedShaban: Basic operation of Unit of Work: Save
        public void Save();
    }
}
