﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Gourmet_s_Choice.Helper
{
    class RandomIndex
    {
        Random rand = new Random();

        public List<int> GenerateRandIndex(int candidateNumber)
        {
            //DB의 음식 개수를 구한다
            int foodCount = DataRepository.Food.GetFoodCount();

            List<int> randIndexNumbers = new List<int>();

            while (randIndexNumbers.Count < candidateNumber)
            {
                // 라이브러리
                int number = rand.Next(foodCount);
                if (randIndexNumbers.Contains(number) == false)
                    randIndexNumbers.Add(number);
            }

            return randIndexNumbers;
        }

        public List<int> ShuffleIndex(List<int> list)
        {
            var shuffleList = list.OrderBy(item => rand.Next());

            return shuffleList.ToList();
        }
    }
}

