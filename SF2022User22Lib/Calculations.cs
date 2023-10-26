using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User22Lib
{
    public class Calculations
    {
        public struct Interval
        {
            public TimeSpan BeginTime { get; set; }
            public int Duration { get; set; }
            public Interval(TimeSpan beginTime, int duration)
            {
                BeginTime = beginTime;
                Duration = duration;
            }
            public TimeSpan EndTime => BeginTime.Add(TimeSpan.FromMinutes(Duration));

            public override string ToString()
            {
                return $"{BeginTime.Hours}:{BeginTime.Minutes}-{EndTime.Hours}:{EndTime.Minutes}";
            }
            public bool Equals(Interval other) => Interval.Equals(this, other);
            public static bool Equals(Interval left, Interval right)
            {
                bool isBegin = right.BeginTime < left.BeginTime && left.BeginTime < right.EndTime;
                bool isEnd = right.BeginTime < left.EndTime && left.EndTime < right.EndTime;
                return isBegin || isEnd;
            }
        }

        public string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations,
            TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            if (startTimes.Length != durations.Length)
                throw new Exception("Длинна массивов startTimes и durations не совпадают");

            if (beginWorkingTime >= endWorkingTime)
                throw new Exception("Конец рабочего дня раньше или равен началу");

            if (consultationTime <= 0)
                throw new Exception("Необходимое время для менеджера меньше или равно нулю");

            if (beginWorkingTime.TotalMinutes + consultationTime > endWorkingTime.TotalMinutes)
                throw new Exception("Минимальный свободный промежуток занимает больше времени, чем конец рабочего дня");

            List<Interval> freeTimes = new List<Interval>();
            List<Interval> busyTimes = GetBusyIntervals(startTimes, durations, consultationTime);

            while (beginWorkingTime < endWorkingTime)
            {
                var currentInterval = new Interval(beginWorkingTime, consultationTime);
                Interval? tmpTime = TryIntervalOf(
                    currentInterval,
                    busyTimes);

                if (tmpTime == null)
                {
                    freeTimes.Add(currentInterval);
                    beginWorkingTime = beginWorkingTime.Add(TimeSpan.FromMinutes(consultationTime));
                }
                else
                {
                    beginWorkingTime = tmpTime.Value.EndTime;
                }
            }

            var stringTimes = new string[freeTimes.Count];
            for (int i = 0; i < freeTimes.Count; i++)
                stringTimes[i] = freeTimes[i].ToString();
            return stringTimes;
        }
        public List<Interval> GetBusyIntervals(TimeSpan[] startTimes, int[] durations, int consultationTime)
        {
            var stack = new Stack<Interval>();
            int index = 0;
            while (index < startTimes.Length)
            {
                TimeSpan begin = startTimes[index];
                int end = durations[index];

                if (stack.Count != 0)
                {
                    if (stack.Peek().EndTime == begin)
                    {
                        Interval item = stack.Pop();
                        begin = item.BeginTime;
                        end += item.Duration;
                    }
                }

                if (end < consultationTime)
                    end = consultationTime;

                stack.Push(new Interval(begin, end));
                index++;
            }
            return stack.ToList();
        }
        public Interval? TryIntervalOf(Interval interval, List<Interval> busyTimes)
        {
            foreach (var time in busyTimes)
            {
                if (interval.Equals(time))
                    return time;
            }
            return null;
        }
    }
}