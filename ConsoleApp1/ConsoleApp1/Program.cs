using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceTests
{
    public interface ITestpaper
    {
        string Subject { get; }
        string[] MarkScheme { get; }
        string PassMark { get; }
    }

    public interface IStudent
    {
        string[] TestsTaken { get; }
        void TakeTest(ITestpaper paper, string[] answers);
    }

    public class Testpaper : ITestpaper
    {
        public Testpaper(string subject, string[] markScheme, string passMark)
        {
            Subject = subject;
            MarkScheme = markScheme;
            PassMark = passMark;
        }

        public string Subject { get; private set; }

        public string[] MarkScheme { get; private set; }

        public string PassMark { get; private set; }
    }

    public class Student : IStudent
    {
        Dictionary<string, string> _results = new Dictionary<string, string>();

        public string[] TestsTaken { get; private set; } = { "No tests taken" };

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            string pass = "Passed", fail = "Failed";
            var score = (int)Math.Round((float)answers.Select((a, i) => a == paper.MarkScheme[i] ? 1 : 0).Sum() * 100 / paper.MarkScheme.Length);
            var passMark = int.Parse(paper.PassMark.Substring(0, paper.PassMark.Length - 1));
            _results.Add(paper.Subject, $"{(score >= passMark ? pass : fail)}! ({score}%)");
            TestsTaken = _results.OrderBy(kvp => kvp.Key).Select(kvp => $"{kvp.Key}: {kvp.Value}").ToArray();
        }
    }
}