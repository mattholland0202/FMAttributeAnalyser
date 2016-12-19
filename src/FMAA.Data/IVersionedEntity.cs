namespace FMAA.Data
{
    public interface IVersionedEntity
    {
        byte[] Version { get; set; }
    }
}
