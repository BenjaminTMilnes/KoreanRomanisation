using Xunit;

namespace KoreanRomanisation.Tests
{
    /// <summary>
    /// A set of tests for the Yale Romanisation converter.
    /// </summary>
    public sealed class YaleRomanisationTests
    {
        private YaleRomanisation YaleRomanisation1;

        public YaleRomanisationTests()
        {
            YaleRomanisation1 = new YaleRomanisation();
        }

        [Theory]
        [InlineData("아", "a")]
        [InlineData("어", "e")]
        [InlineData("이", "i")]
        [InlineData("애", "ay")]
        [InlineData("에", "ey")]
        [InlineData("오", "o")]
        [InlineData("우", "u")]
        [InlineData("으", "u")]
        [InlineData("야", "ya")]
        [InlineData("여", "ye")]
        [InlineData("얘", "yay")]
        [InlineData("예", "yey")]
        [InlineData("요", "yo")]
        [InlineData("유", "yu")]
        [InlineData("와", "wa")]
        [InlineData("워", "we")]
        [InlineData("왜", "way")]
        [InlineData("웨", "wey")]
        [InlineData("외", "oy")]
        [InlineData("의", "uy")]
        [InlineData("위", "wi")]
        [InlineData("가", "ka")]
        [InlineData("까", "kka")]
        [InlineData("나", "na")]
        [InlineData("다", "ta")]
        [InlineData("따", "tta")]
        [InlineData("라", "la")]
        [InlineData("마", "ma")]
        [InlineData("바", "pa")]
        [InlineData("빠", "ppa")]
        [InlineData("사", "sa")]
        [InlineData("싸", "ssa")]
        [InlineData("자", "ca")]
        [InlineData("짜", "cca")]
        [InlineData("차", "cha")]
        [InlineData("카", "kha")]
        [InlineData("타", "tha")]
        [InlineData("파", "pha")]
        [InlineData("하", "ha")]
        [InlineData("각", "kak")]
        [InlineData("갂", "kakk")]
        [InlineData("간", "kan")]
        [InlineData("갇", "kat")]
        [InlineData("갈", "kal")]
        [InlineData("감", "kam")]
        [InlineData("갑", "kap")]
        [InlineData("갓", "kas")]
        [InlineData("갔", "kass")]
        [InlineData("강", "kang")]
        [InlineData("갖", "kac")]
        [InlineData("갗", "kach")]
        [InlineData("갘", "kakh")]
        [InlineData("같", "kath")]
        [InlineData("갚", "kaph")]
        [InlineData("갛", "kah")]
        [InlineData("갃가", "kakska")]
        [InlineData("갃아", "kaks.a")]
        [InlineData("갅가", "kancka")]
        [InlineData("갅아", "kanc.a")]
        [InlineData("갆가", "kanhka")]
        [InlineData("갆아", "kanh.a")]
        [InlineData("갉가", "kalk.ka")]
        [InlineData("갉아", "kalk.a")]
        [InlineData("갊가", "kalmka")]
        [InlineData("갊아", "kalm.a")]
        [InlineData("갋가", "kalpka")]
        [InlineData("갋아", "kalp.a")]
        [InlineData("갌가", "kalska")]
        [InlineData("갌아", "kals.a")]
        [InlineData("갍가", "kalthka")]
        [InlineData("갍아", "kalth.a")]
        [InlineData("갎가", "kalphka")]
        [InlineData("갎아", "kalph.a")]
        [InlineData("갏가", "kalhka")]
        [InlineData("갏아", "kalh.a")]
        [InlineData("값가", "kapska")]
        [InlineData("값아", "kaps.a")]
        public void RomaniseTextTest(string Korean, string ExpectedRomanisation)
        {
            YaleRomanisation1.UseSh = false;

            Assert.Equal(ExpectedRomanisation, YaleRomanisation1.RomaniseText(Korean));
        }
    }
}
