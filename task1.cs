using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.task1
{
    internal class Task1 : Program
    {
        public void StartTask()
        {
            //��� �������� ����-���� �����
            int[] numbers = new int[3];
            //����� ����� ��� ����������� �����
            int[] arr = new int[3];
            //��� ����� arr ��� ��������� �����������
            int index = 0;
            //�� ����� � ����� 23
            int num = 24;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                if (numbers[i] < (10 + num) && numbers[i] > 0)
                {
                    arr[index] = numbers[i];
                    index++;
                }
            }

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }

    }
}