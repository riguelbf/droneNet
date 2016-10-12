
using System;
using System.Collections.Generic;
using System.Linq;
using Algorithm.Logic.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm.Logic.Tests.Build
{
    [TestClass]
    public class BuildCoordinateTest
    {

        [TestMethod]
        public IList<String> SeparateInBlocksTest(string entry = "NNNXLLLXX")
        {
            var block = String.Empty;

            entry.ToCharArray().ToList().ForEach(e =>
            {
                if (String.IsNullOrEmpty(block)) { block += e; return;}

                var value = 0;
                int.TryParse(e.ToString(), out value);

                if (value != 0)
                {
                    block += e;
                }
                else if (e.ToString().Equals("X"))
                {
                    block = block.Substring(0,block.LastIndexOf('|'));
                }
                else
                {
                    block += String.Format("|{0}", e.ToString());
                }
            });

            return block.Split('|').ToList();
        }

        [TestMethod]
        public void CalculateBlocksTest()
        {
            var blocks = SeparateInBlocksTest("S5O5");

            var cardinalPoint = new CardinalPoints();

            blocks.OrderBy(i => i)
                  .ToList()
                  .ForEach(block =>
                  {
                      cardinalPoint.ActualPoint = block.ToLower().Substring(0, 1);
                      switch (cardinalPoint.ActualPoint)
                      {
                          case "n" :
                              cardinalPoint.North += SumValue(cardinalPoint, block); 
                              break;
                          
                          case "s":
                              cardinalPoint.South += SumValue(cardinalPoint, block) * -1; 
                              break;
                          
                          case "l":
                              cardinalPoint.East += SumValue(cardinalPoint, block); 
                              break;
                          
                          case "o":
                              cardinalPoint.West += SumValue(cardinalPoint, block) * -1; 
                              break;
                      }
                  });

        }

        private void SubtractValue(CardinalPoints cardinalPoint, string block)
        {
            throw new NotImplementedException();
        }

        private static int SumValue(CardinalPoints coodinate, string block)
        {
            if (coodinate.ActualPoint.Contains("x")) return 0;

            var value = block.ToLower().Replace(coodinate.ActualPoint, String.Empty);
            return String.IsNullOrEmpty(value) ? 1 : int.Parse(value);
        }
    }
}
