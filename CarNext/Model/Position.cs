using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNext.Model
{
    public struct Position
    {
        public double Latitude { get; }

        public double Longitude { get; }

        public Position(double latitude, double longitude)
        {
            Latitude = Math.Min(Math.Max(latitude, -90.0), 90.0);
            Longitude = Math.Min(Math.Max(longitude, -180.0), 180.0);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Position) || (object)this == null)
            {
                return false;
            }

            Position position = (Position)obj;
            if (Latitude == position.Latitude)
            {
                return Longitude == position.Longitude;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return (Latitude.GetHashCode() * 397) ^ Longitude.GetHashCode();
        }

        public static bool operator ==(Position left, Position right)
        {
            return object.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !object.Equals(left, right);
        }

        public static Position operator -(Position left, Position right)
        {
            return new Position(left.Latitude - right.Latitude, left.Longitude - right.Longitude);
        }
    }
}
