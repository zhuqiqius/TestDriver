using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.Matrices
{
    // Given an image represented by an NxN matrix, where each pixel in the image is 4 bytes, write a method
    // to rotate the image by 90 degrees. Can you do this in place?
    public static class RotateImage
    {
        public static int[,] Rotate(int[,] image)
        {
            // Print out image before rotation
            PrintImage(image);

            if (image == null)
            {
                Console.WriteLine("Cannot rotate an image that's null!");
                return null;
            }

            int n = image.Length / 2; // Get the size of the image matrix
            if (n <= 1)
            {
                return image;
            }
            else
            {
                int[,] newImage = new int[n, n]; // Initialize a new two-dimensional array for saving the rotated image
                for (int j = 0; j < n; j++)
                {
                    for (int i = n - 1; i >= 0; i--)
                    {
                        newImage[j, n - 1 - i] = image[i, j];
                    }
                }

                // Print out the image after rotation
                PrintImage(newImage); 
                return newImage;
            }
        }

        // Try rotate the image in place, by using the same 2-D array.
        public static int[,] RotateInPlace(int[,] image)
        {
            throw new NotImplementedException();
        }

        private static void PrintImage(int[,] image)
        {
            int size = image.Length / 2;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(image[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
