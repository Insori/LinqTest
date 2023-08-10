using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqTest
{
    public partial class Form1 : Form
    {
        static private List<Movie> movies = new List<Movie>()
        {
            new Movie() { Name = "엘리멘탈", ReleaseDate = 2023, Country = "미국"},
            new Movie() { Name = "붏한당: 나쁜 놈들의 세상", ReleaseDate = 2017, Country = "한국"},
            new Movie() { Name = "어바웃타임", ReleaseDate = 2013, Country = "영국"},
            new Movie() { Name = "레옹", ReleaseDate = 1995, Country = "프랑스"},
            new Movie() { Name = "베놈", ReleaseDate = 2018, Country = "미국"},
            new Movie() { Name = "헌트", ReleaseDate = 2022, Country = "한국"},
            new Movie() { Name = "히말라야", ReleaseDate = 2015, Country = "한국"},
            new Movie() { Name = "어메이징 스파이더맨", ReleaseDate = 2015, Country = "미국"},
            new Movie() { Name = "타이타닉", ReleaseDate = 1997, Country = "미국"},
            new Movie() { Name = "이터널 선샤인", ReleaseDate = 2004, Country = "프랑스"},
            new Movie() { Name = "매드 맥스: 분노의 도로", ReleaseDate = 2015, Country = "호주"},
            new Movie() { Name = "늑대아이", ReleaseDate = 2012, Country = "일본"},
            new Movie() { Name = "위대한 개츠비", ReleaseDate = 2013, Country = "호주"},
            new Movie() { Name = "오직 사랑하는 이들만이 살아남는다", ReleaseDate = 2014, Country = "러시아"},
            new Movie() { Name = "레지던트 이블: 파멸의 날", ReleaseDate = 2017, Country = "러시아"},
            new Movie() { Name = "나는 네가 지난 여름에 한 일을 알고 있다", ReleaseDate = 1998, Country = "미국"},
            new Movie() { Name = "겨울왕국", ReleaseDate = 2014, Country = "미국"},
            new Movie() { Name = "스즈메의 문단속", ReleaseDate = 2022, Country = "일본"},
            new Movie() { Name = "극한직업", ReleaseDate = 2019, Country = "한국"},
            new Movie() { Name = "올드보이", ReleaseDate = 2003, Country = "한국"},
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movieBindingSource.DataSource = movies;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movieBindingSource.DataSource = from item in movies
                                            orderby item.Name ascending
                                            select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movieBindingSource.DataSource = from item in movies
                                            orderby item.ReleaseDate descending
                                            select item;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movieBindingSource.DataSource = from item in movies
                                            where item.ReleaseDate > 2015
                                            orderby item.Name descending
                                            select item;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            movieBindingSource.DataSource = from item in movies
                                            where item.Country == "한국"
                                            orderby item.Name descending
                                            select item;
        }
    }
}
