namespace PeriodicTable.ElementUtilities
{
    public interface IAtom
    {
        int Protons { get; }
        int Neutrons { get; }
        int Electrons { get; }
        bool Radioactive { get; set; }
    }
}
