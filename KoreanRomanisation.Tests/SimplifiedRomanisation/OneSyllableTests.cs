﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KoreanRomanisation.Tests.SimplifiedRomanisation
{
    public class OneSyllableTests
    {
        private readonly KoreanRomanisation.SimplifiedRomanisation SimplifiedRomanisation1;

        public OneSyllableTests()
        {
            SimplifiedRomanisation1 = new KoreanRomanisation.SimplifiedRomanisation();
        }

        [Theory]
        [InlineData("아", "a")]
        [InlineData("어", "o")]
        [InlineData("이", "i")]
        [InlineData("애", "e")]
        [InlineData("에", "ei")]
        [InlineData("오", "o")]
        [InlineData("우", "oo")]
        [InlineData("으", "u")]
        [InlineData("야", "ya")]
        [InlineData("여", "yo")]
        [InlineData("얘", "ye")]
        [InlineData("예", "yei")]
        [InlineData("요", "yo")]
        [InlineData("유", "yoo")]
        [InlineData("와", "wa")]
        [InlineData("워", "wo")]
        [InlineData("왜", "we")]
        [InlineData("웨", "wei")]
        [InlineData("외", "we")]
        [InlineData("의", "ui")]
        [InlineData("위", "wi")]
        [InlineData("가", "ka")]
        [InlineData("까", "kka")]
        [InlineData("나", "na")]
        [InlineData("다", "ta")]
        [InlineData("따", "tta")]
        [InlineData("라", "ra")]
        [InlineData("마", "ma")]
        [InlineData("바", "pa")]
        [InlineData("빠", "ppa")]
        [InlineData("사", "sa")]
        [InlineData("싸", "tsa")]
        [InlineData("자", "cha")]
        [InlineData("짜", "tcha")]
        [InlineData("차", "cha")]
        [InlineData("카", "ka")]
        [InlineData("타", "ta")]
        [InlineData("파", "pa")]
        [InlineData("하", "ha")]
        [InlineData("각", "kak")]
        [InlineData("갂", "kak")]
        [InlineData("간", "kan")]
        [InlineData("갇", "kat")]
        [InlineData("갈", "kal")]
        [InlineData("감", "kam")]
        [InlineData("갑", "kap")]
        [InlineData("갓", "kat")]
        [InlineData("갔", "kat")]
        [InlineData("강", "kang")]
        [InlineData("갖", "kat")]
        [InlineData("갗", "kat")]
        [InlineData("갘", "kak")]
        [InlineData("같", "kat")]
        [InlineData("갚", "kap")]
        [InlineData("갛", "kat")]
        [InlineData("시", "si")]
        [InlineData("샤", "sya")]
        [InlineData("셔", "syo")]
        [InlineData("섀", "sye")]
        [InlineData("셰", "syei")]
        [InlineData("쇼", "syo")]
        [InlineData("슈", "syoo")]
        [InlineData("씨", "si")]
        [InlineData("쌰", "sya")]
        [InlineData("쎠", "syo")]
        [InlineData("썌", "sye")]
        [InlineData("쎼", "syei")]
        [InlineData("쑈", "syo")]
        [InlineData("쓔", "syoo")]
        [InlineData("각가", "kakka")]
        [InlineData("갂가", "kakka")]
        [InlineData("간가", "kan'ga")]
        [InlineData("갇가", "katka")]
        [InlineData("갈가", "kalga")]
        [InlineData("감가", "kamga")]
        [InlineData("갑가", "kapka")]
        [InlineData("갓가", "katka")]
        [InlineData("갔가", "katka")]
        [InlineData("강가", "kangga")]
        [InlineData("갖가", "katka")]
        [InlineData("갗가", "katka")]
        [InlineData("갘가", "kakka")]
        [InlineData("같가", "katka")]
        [InlineData("갚가", "kapka")]
        [InlineData("갛가", "katka")]
        [InlineData("각까", "kakka")]
        [InlineData("갂까", "kakka")]
        [InlineData("간까", "kankka")]
        [InlineData("갇까", "katkka")]
        [InlineData("갈까", "kalkka")]
        [InlineData("감까", "kamkka")]
        [InlineData("갑까", "kapkka")]
        [InlineData("갓까", "katkka")]
        [InlineData("갔까", "katkka")]
        [InlineData("강까", "kangkka")]
        [InlineData("갖까", "katkka")]
        [InlineData("갗까", "katkka")]
        [InlineData("갘까", "kakka")]
        [InlineData("같까", "katkka")]
        [InlineData("갚까", "kapkka")]
        [InlineData("갛까", "katkka")]
        [InlineData("각나", "kangna")]
        [InlineData("갂나", "kangna")]
        [InlineData("간나", "kanna")]
        [InlineData("갇나", "kanna")]
        [InlineData("갈나", "kalla")]
        [InlineData("감나", "kamna")]
        [InlineData("갑나", "kamna")]
        [InlineData("갓나", "kanna")]
        [InlineData("갔나", "kanna")]
        [InlineData("강나", "kangna")]
        [InlineData("갖나", "kanna")]
        [InlineData("갗나", "kanna")]
        [InlineData("갘나", "kangna")]
        [InlineData("같나", "kanna")]
        [InlineData("갚나", "kamna")]
        [InlineData("갛나", "kanna")]
        [InlineData("각다", "kakta")]
        [InlineData("갂다", "kakta")]
        [InlineData("간다", "kanda")]
        [InlineData("갇다", "katta")]
        [InlineData("갈다", "kalda")]
        [InlineData("감다", "kamda")]
        [InlineData("갑다", "kapta")]
        [InlineData("갓다", "katta")]
        [InlineData("갔다", "katta")]
        [InlineData("강다", "kangda")]
        [InlineData("갖다", "katta")]
        [InlineData("갗다", "katta")]
        [InlineData("갘다", "kakta")]
        [InlineData("같다", "katta")]
        [InlineData("갚다", "kapta")]
        [InlineData("갛다", "katta")]
        [InlineData("각따", "kaktta")]
        [InlineData("갂따", "kaktta")]
        [InlineData("간따", "kantta")]
        [InlineData("갇따", "katta")]
        [InlineData("갈따", "kaltta")]
        [InlineData("감따", "kamtta")]
        [InlineData("갑따", "kaptta")]
        [InlineData("갓따", "katta")]
        [InlineData("갔따", "katta")]
        [InlineData("강따", "kangtta")]
        [InlineData("갖따", "katta")]
        [InlineData("갗따", "katta")]
        [InlineData("갘따", "kaktta")]
        [InlineData("같따", "katta")]
        [InlineData("갚따", "kaptta")]
        [InlineData("갛따", "katta")]
        [InlineData("각라", "kangna")]
        [InlineData("갂라", "kangna")]
        [InlineData("간라", "kalla")]
        [InlineData("갇라", "kanna")]
        [InlineData("갈라", "kalla")]
        [InlineData("감라", "kamna")]
        [InlineData("갑라", "kamna")]
        [InlineData("갓라", "kanna")]
        [InlineData("갔라", "kanna")]
        [InlineData("강라", "kangna")]
        [InlineData("갖라", "kanna")]
        [InlineData("갗라", "kanna")]
        [InlineData("갘라", "kangna")]
        [InlineData("같라", "kanna")]
        [InlineData("갚라", "kamna")]
        [InlineData("갛라", "kanna")]
        [InlineData("각마", "kangma")]
        [InlineData("갂마", "kangma")]
        [InlineData("간마", "kanma")]
        [InlineData("갇마", "kanma")]
        [InlineData("갈마", "kalma")]
        [InlineData("감마", "kamma")]
        [InlineData("갑마", "kamma")]
        [InlineData("갓마", "kanma")]
        [InlineData("갔마", "kanma")]
        [InlineData("강마", "kangma")]
        [InlineData("갖마", "kanma")]
        [InlineData("갗마", "kanma")]
        [InlineData("갘마", "kangma")]
        [InlineData("같마", "kanma")]
        [InlineData("갚마", "kamma")]
        [InlineData("갛마", "kanma")]
        [InlineData("각바", "kakpa")]
        [InlineData("갂바", "kakpa")]
        [InlineData("간바", "kanba")]
        [InlineData("갇바", "katpa")]
        [InlineData("갈바", "kalba")]
        [InlineData("감바", "kamba")]
        [InlineData("갑바", "kappa")]
        [InlineData("갓바", "katpa")]
        [InlineData("갔바", "katpa")]
        [InlineData("강바", "kangba")]
        [InlineData("갖바", "katpa")]
        [InlineData("갗바", "katpa")]
        [InlineData("갘바", "kakpa")]
        [InlineData("같바", "katpa")]
        [InlineData("갚바", "kappa")]
        [InlineData("갛바", "katpa")]
        [InlineData("각빠", "kakppa")]
        [InlineData("갂빠", "kakppa")]
        [InlineData("간빠", "kanppa")]
        [InlineData("갇빠", "katppa")]
        [InlineData("갈빠", "kalppa")]
        [InlineData("감빠", "kamppa")]
        [InlineData("갑빠", "kappa")]
        [InlineData("갓빠", "katppa")]
        [InlineData("갔빠", "katppa")]
        [InlineData("강빠", "kangppa")]
        [InlineData("갖빠", "katppa")]
        [InlineData("갗빠", "katppa")]
        [InlineData("갘빠", "kakppa")]
        [InlineData("같빠", "katppa")]
        [InlineData("갚빠", "kappa")]
        [InlineData("갛빠", "katppa")]
        [InlineData("각사", "kaksa")]
        [InlineData("갂사", "kaksa")]
        [InlineData("간사", "kansa")]
        [InlineData("갇사", "katsa")]
        [InlineData("갈사", "kalsa")]
        [InlineData("감사", "kamsa")]
        [InlineData("갑사", "kapsa")]
        [InlineData("갓사", "kassa")]
        [InlineData("갔사", "kassa")]
        [InlineData("강사", "kangsa")]
        [InlineData("갖사", "katsa")]
        [InlineData("갗사", "katsa")]
        [InlineData("갘사", "kaksa")]
        [InlineData("같사", "katsa")]
        [InlineData("갚사", "kapsa")]
        [InlineData("갛사", "katsa")]
        [InlineData("각싸", "kaktsa")]
        [InlineData("갂싸", "kaktsa")]
        [InlineData("간싸", "kantsa")]
        [InlineData("갇싸", "kattsa")]
        [InlineData("갈싸", "kaltsa")]
        [InlineData("감싸", "kamtsa")]
        [InlineData("갑싸", "kaptsa")]
        [InlineData("갓싸", "kattsa")]
        [InlineData("갔싸", "kattsa")]
        [InlineData("강싸", "kangtsa")]
        [InlineData("갖싸", "kattsa")]
        [InlineData("갗싸", "kattsa")]
        [InlineData("갘싸", "kaktsa")]
        [InlineData("같싸", "kattsa")]
        [InlineData("갚싸", "kaptsa")]
        [InlineData("갛싸", "kattsa")]
        [InlineData("각아", "kaga")]
        [InlineData("갂아", "kakka")]
        [InlineData("간아", "kana")]
        [InlineData("갇아", "kada")]
        [InlineData("갈아", "kara")]
        [InlineData("감아", "kama")]
        [InlineData("갑아", "kaba")]
        [InlineData("갓아", "kasa")]
        [InlineData("갔아", "katsa")]
        [InlineData("강아", "kang'a")]
        [InlineData("갖아", "kaja")]
        [InlineData("갗아", "kacha")]
        [InlineData("갘아", "kaka")]
        [InlineData("같아", "kata")]
        [InlineData("갚아", "kapa")]
        [InlineData("갛아", "kaha")]
        [InlineData("각자", "kakcha")]
        [InlineData("갂자", "kakcha")]
        [InlineData("간자", "kanja")]
        [InlineData("갇자", "katcha")]
        [InlineData("갈자", "kalja")]
        [InlineData("감자", "kamja")]
        [InlineData("갑자", "kapcha")]
        [InlineData("갓자", "katcha")]
        [InlineData("갔자", "katcha")]
        [InlineData("강자", "kangja")]
        [InlineData("갖자", "katcha")]
        [InlineData("갗자", "katcha")]
        [InlineData("갘자", "kakcha")]
        [InlineData("같자", "katcha")]
        [InlineData("갚자", "kapcha")]
        [InlineData("갛자", "katcha")]
        [InlineData("각짜", "kaktcha")]
        [InlineData("갂짜", "kaktcha")]
        [InlineData("간짜", "kantcha")]
        [InlineData("갇짜", "kattcha")]
        [InlineData("갈짜", "kaltcha")]
        [InlineData("감짜", "kamtcha")]
        [InlineData("갑짜", "kaptcha")]
        [InlineData("갓짜", "kattcha")]
        [InlineData("갔짜", "kattcha")]
        [InlineData("강짜", "kangtcha")]
        [InlineData("갖짜", "kattcha")]
        [InlineData("갗짜", "kattcha")]
        [InlineData("갘짜", "kaktcha")]
        [InlineData("같짜", "kattcha")]
        [InlineData("갚짜", "kaptcha")]
        [InlineData("갛짜", "kattcha")]
        [InlineData("각차", "kakcha")]
        [InlineData("갂차", "kakcha")]
        [InlineData("간차", "kancha")]
        [InlineData("갇차", "katcha")]
        [InlineData("갈차", "kalcha")]
        [InlineData("감차", "kamcha")]
        [InlineData("갑차", "kapcha")]
        [InlineData("갓차", "katcha")]
        [InlineData("갔차", "katcha")]
        [InlineData("강차", "kangcha")]
        [InlineData("갖차", "katcha")]
        [InlineData("갗차", "katcha")]
        [InlineData("갘차", "kakcha")]
        [InlineData("같차", "katcha")]
        [InlineData("갚차", "kapcha")]
        [InlineData("갛차", "katcha")]
        [InlineData("각카", "kakka")]
        [InlineData("갂카", "kakka")]
        [InlineData("간카", "kanka")]
        [InlineData("갇카", "katka")]
        [InlineData("갈카", "kalka")]
        [InlineData("감카", "kamka")]
        [InlineData("갑카", "kapka")]
        [InlineData("갓카", "katka")]
        [InlineData("갔카", "katka")]
        [InlineData("강카", "kangka")]
        [InlineData("갖카", "katka")]
        [InlineData("갗카", "katka")]
        [InlineData("갘카", "kakka")]
        [InlineData("같카", "katka")]
        [InlineData("갚카", "kapka")]
        [InlineData("갛카", "katka")]
        [InlineData("각타", "kakta")]
        [InlineData("갂타", "kakta")]
        [InlineData("간타", "kanta")]
        [InlineData("갇타", "katta")]
        [InlineData("갈타", "kalta")]
        [InlineData("감타", "kamta")]
        [InlineData("갑타", "kapta")]
        [InlineData("갓타", "katta")]
        [InlineData("갔타", "katta")]
        [InlineData("강타", "kangta")]
        [InlineData("갖타", "katta")]
        [InlineData("갗타", "katta")]
        [InlineData("갘타", "kakta")]
        [InlineData("같타", "katta")]
        [InlineData("갚타", "kapta")]
        [InlineData("갛타", "katta")]
        [InlineData("각파", "kakpa")]
        [InlineData("갂파", "kakpa")]
        [InlineData("간파", "kanpa")]
        [InlineData("갇파", "katpa")]
        [InlineData("갈파", "kalpa")]
        [InlineData("감파", "kampa")]
        [InlineData("갑파", "kappa")]
        [InlineData("갓파", "katpa")]
        [InlineData("갔파", "katpa")]
        [InlineData("강파", "kangpa")]
        [InlineData("갖파", "katpa")]
        [InlineData("갗파", "katpa")]
        [InlineData("갘파", "kakpa")]
        [InlineData("같파", "katpa")]
        [InlineData("갚파", "kappa")]
        [InlineData("갛파", "katpa")]
        [InlineData("각하", "kaka")]
        [InlineData("갂하", "kaka")]
        [InlineData("간하", "kana")]
        [InlineData("갇하", "kata")]
        [InlineData("갈하", "kara")]
        [InlineData("감하", "kama")]
        [InlineData("갑하", "kapa")]
        [InlineData("갓하", "kata")]
        [InlineData("갔하", "kata")]
        [InlineData("강하", "kangha")]
        [InlineData("갖하", "kata")]
        [InlineData("갗하", "kata")]
        [InlineData("갘하", "kaka")]
        [InlineData("같하", "kata")]
        [InlineData("갚하", "kapa")]
        [InlineData("갛하", "kata")]
        public void Romanise(string Korean, string Romanisation)
        {
            SimplifiedRomanisation1.UseSh = false;
            Assert.Equal(Romanisation, SimplifiedRomanisation1.Romanise(Korean));
        }

        [Theory]
        [InlineData("시", "shi")]
        [InlineData("샤", "shya")]
        [InlineData("셔", "shyo")]
        [InlineData("섀", "shye")]
        [InlineData("셰", "shyei")]
        [InlineData("쇼", "shyo")]
        [InlineData("슈", "shyoo")]
        [InlineData("씨", "shi")]
        [InlineData("쌰", "shya")]
        [InlineData("쎠", "shyo")]
        [InlineData("썌", "shye")]
        [InlineData("쎼", "shyei")]
        [InlineData("쑈", "shyo")]
        [InlineData("쓔", "shyoo")]
        public void RomaniseUsingSh(string Korean, string Romanisation)
        {
            SimplifiedRomanisation1.UseSh = true;
            Assert.Equal(Romanisation, SimplifiedRomanisation1.Romanise(Korean));
        }
    }
}
