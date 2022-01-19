using Mutagen.Bethesda;
using Mutagen.Bethesda.Environments;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Strings;
using Noggog;

Console.WriteLine("Hello, World!");

var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimLE);

var lookupOverlay = StringsFolderLookupOverlay.TypicalFactory(GameRelease.SkyrimLE, "Skyrim.esm", env.DataFolderPath, null);

foreach (var src in EnumExt.GetValues<StringsSource>())
{
    Console.WriteLine($"{src}:");
    foreach (var lang in lookupOverlay.AvailableLanguages(src))
    {
        Console.WriteLine($"   {lang}");
    }
}
