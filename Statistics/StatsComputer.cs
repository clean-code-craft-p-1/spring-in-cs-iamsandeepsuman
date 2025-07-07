using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer {
        public StatsResult CalculateStatistics(List<float> numbers) {
            if (numbers == null || numbers.Count == 0) {
                return new StatsResult {
                    average = double.NaN,
                    min = double.NaN,
                    max = double.NaN
                };
            }

            double sum = 0;
            double min = numbers[0];
            double max = numbers[0];

            foreach (var num in numbers) {
                sum += num;

                if (num < min) {
                    min = num;
                }

                if (num > max) {
                    max = num;
                }
            }

            return new StatsResult {
                average = sum / numbers.Count,
                min = min,
                max = max
            };
        }
    }
}
