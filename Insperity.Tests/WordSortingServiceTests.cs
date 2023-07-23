using System;
using System.Linq;
using Insperity.Core.Services;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Insperity.Tests;

public class WordSortingServiceTests
{
    private readonly ITestOutputHelper _outputHelper;
    private readonly IWordSortingService _sut;

    public WordSortingServiceTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
        _sut = new WordSortingService();
    }

    [Theory]
    [InlineData(
        new string[]
        {
            "abaccadcc", 
            "xyzxy"
        }, 
        new string[]
        {
            "ccccaaabd", 
            "xxyyz"
        })]
    [InlineData(new string[]
        {
            "dulgvgzwqg",
            "gxtjtmtywr",
            "hnlnxiupgt",
            "gzjotckivp",
            "dpwwsdptae",
            "pcscpilknb",
            "btvyhhmflf",
            "artrtnqxcr",
            "nrtcmcoadn",
            "fkdsgnekft",
        },
        new string[]
        {
            "gggdlquvwz",
            "tttgjmrwxy",
            "nnghilptux",
            "cgijkoptvz",
            "ddppwwaest",
            "ccppbiklns",
            "ffhhblmtvy",
            "rrrttacnqx",
            "ccnnadmort",
            "ffkkdegnst",
        })]
    [InlineData(
        new string[]
        {
            "wzenwebuau",
            "vokfxzynwl",
            "neldfeyrxk",
            "waqdfiodgs",
            "ykiuvzfcbc"
        },
        new string[]
        {
            "eeuuwwabnz",
            "fklnovwxyz",
            "eedfklnrxy",
            "ddafgioqsw",
            "ccbfikuvyz"
        })]
    [InlineData(
        new string[]
        {
            "qakmc",
            "rrtbk",
            "vaixn",
            "wmpnj",
            "uproi",
            "btska",
            "ejqwr",
            "elwlg",
            "oaoiy",
            "hrqkn"
        },
        new string[]
        {
            "ackmq",
            "rrbkt",
            "ainvx",
            "jmnpw",
            "iopru",
            "abkst",
            "ejqrw",
            "llegw",
            "ooaiy",
            "hknqr"
        })]
    [InlineData(
        new string[]
        {
            "pzjim",
            "njnfq",
            "xyohs"
        },
        new string[]
        {
            "ijmpz",
            "nnfjq",
            "hosxy"
        })]
    [InlineData(
        new string[]
        {
            "xqycs",
            "beoax",
            "afkso",
            "bldit",
            "gwrys"
        },
        new string[]
        {
            "cqsxy",
            "abeox",
            "afkos",
            "bdilt",
            "grswy"
        })]
    public void SortingOperations_ShouldReturn_SortedListOfWords(string[] input, string[] output)
    {
        // Arrange
        // Nothing to arrange
        // Act
        var results = _sut.SortingOperations(input);

        // Assert
        Assert.Equal(output, results);
    }
}