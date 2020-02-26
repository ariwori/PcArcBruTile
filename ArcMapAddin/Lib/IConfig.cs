using BruTile;

namespace ArcMapAddin.Lib
{
    public interface IConfig
    {
        ITileSource CreateTileSource();
    }
}
