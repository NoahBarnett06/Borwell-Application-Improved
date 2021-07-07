using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorwellChallenge
{
    public class Room
    {
        // Publicly declares the variables used in the this class, and also sets their datatypes
        public decimal Width;
        public decimal Length;
        public decimal Height;
        public decimal OpeningHeight;
        public decimal OpeningWidth;
        public int OpeningCount;
        public decimal OpeningTotal;

        // Calculates the area of the walls
        public decimal Wall1
        {
            get { return Length * Height; }
        }
        public decimal Wall2
        {
            get { return Width * Height; }
        }
        public decimal WallTotal
        {
            get { return 2 * (Wall1 + Wall2); }
        }

        // Calculates the volume of the room
        public decimal Volume
        {
            get { return Width * Length * Height; }
        }
        
        // Calculate the area of the floor
        public decimal FloorArea
        {
            get { return Width * Length; }
        }

        // Caclulates the area of the opening (door/window) and rounds it to two decimal places, also adds this value to a rolling total of opening area
        public decimal Opening
        {
            get
            {
                var Open = Math.Round(OpeningHeight * OpeningWidth, 2);
                OpeningTotal += Open;
                return Open;
            }
        }

        // Counts the number of openings added
        public int OpeningNumber
        {
            get { return OpeningCount += 1; }               
        }

        // Clears the currently stored openings when the page is closed
        public void ClearOpenings()
        {
            OpeningCount = 0;
            OpeningTotal = 0;
        }

        // Calculates how many litres of paint are needed to cover the area of the walls using a ratio of 10:1 for area of the walls(m²) to litres of paint
        public decimal Paint
        {
            get
            {
                var PaintArea = (WallTotal - OpeningTotal) / 10;
                if (PaintArea < 1)
                {
                    return 1;
                }
                if (PaintArea > Math.Round(PaintArea))
                {
                    PaintArea = Math.Round(PaintArea);
                    return PaintArea += 1;
                }
                else
                {
                    return PaintArea = Math.Round(PaintArea);
                }
            }
        }
        
    }
}
