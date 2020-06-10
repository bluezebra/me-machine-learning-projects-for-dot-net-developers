using System;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var distance = new ManhattanDistance();
            var classifier = new BasicClassifier(distance);

            const string trainingPath = 
                @"E:\git-personal\me-machine-learning-projects-for-dot-net-developers\chapter-1\DigitsRecognizer\Data\trainingsample.csv";

            var training = DataReader.ReadObservations(trainingPath);
            classifier.Train(training);

            const string validationPath = @"E:\git-personal\me-machine-learning-projects-for-dot-net-developers\chapter-1\DigitsRecognizer\Data\validationsample.csv";
            var validation = DataReader.ReadObservations(validationPath);

            var correct = Evaluator.Correct(validation, classifier);

            Console.WriteLine("Correctly classified: {0:P2}", correct);
            Console.ReadLine();
        }
    }
}
