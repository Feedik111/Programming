namespace Programming.Model
{
    using System;
    
    public class Song
    {
        private int _durationSeconds;

        public Song()
        {
        }

        public Song(string artist,
            string name,
            int durationSeconds)
        {
            Artist = artist;
            Name = name;
            DurationSeconds = durationSeconds;
        }

        public string Artist { get; set; }
        
        public string Name { get; set; }

        public int DurationSeconds
        {
            get
            {
                return _durationSeconds;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "the value of the Duration Seconds field must be greater than zero");
                }

                _durationSeconds = value;
            }
        }
    }
}