using System;

namespace AvevaWord
{
    public class Sequencer
    {
        public bool DoesStringContainLetters(string letters, string toCheck)
        {
            if (letters.Length == 1)
            {
                return toCheck.Contains(letters);
            }
            else
            {
                bool containsLetters = true;

                foreach (char letter in letters)
                {
                    if (!toCheck.Contains(letter))
                    {
                        containsLetters = false;
                        break;
                    }
                }

                return containsLetters;
            }
            return false;
        }

        public bool DoesStringContainLettersInSequence(string letters, string toCheck)
        {
            // Fail fast
            if (!DoesStringContainLetters(letters, toCheck))
            {
                return false;
            }

            if (letters.Length == 1)
            {
                return toCheck.Contains(letters);
            }
            else
            {
                bool containsSequence = true;
                int previousIndex = 0;

                foreach (char letter in letters)
                {
                    int charIndex = toCheck.IndexOf(letter);
                    if (charIndex < previousIndex)
                    {
                        containsSequence = false;
                        break;
                    }
                    else
                    {
                        previousIndex = charIndex;
                    }
                }

                return containsSequence;
            }


            return false;
        }
    }
}
