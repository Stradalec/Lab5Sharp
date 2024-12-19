using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;
using Flee.PublicTypes;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using MathNet.Numerics.LinearAlgebra.Solvers;
using System.Diagnostics;
using NPOI.SS.Formula.Functions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Sockets;
using NPOI.HPSF;
using System.Windows.Navigation;
using System.Windows.Media.Media3D;
using ICSharpCode.SharpZipLib.Core;

namespace Lab1
{
    interface IView
    {
        string returnFunction();
        double lowLimit();
        double upLimit();
        double Interval();
        double firstSide();
        double secondSide();
        double epsilon();

        byte Choice();
        void UpdateGraph(List<double[]> inputArr);
        double iterationCount();
        bool MinimumOrMaximum();
        void ShowGraph(PlotModel plotModel);
        void ShowResult(double input, double errorCheck);

        event EventHandler<EventArgs> StartDichotomy;
        event EventHandler<EventArgs> CreateGraph;
        event EventHandler<EventArgs> StartGoldenRatio;
        event EventHandler<EventArgs> StartNewton;
        event EventHandler<EventArgs> StartDescent;
    }

    interface ISortView
    {
        byte StartInput();

        int ArraySizeToRandom();

        int leftInterval();
        int rightInterval();    
        string PathToFile();

        bool IsDouble();
        bool IsActiveBubble();
        bool IsActiveInserts();
        bool IsActiveFast();
        bool IsActiveShake();

        bool IsActiveSwamp();

        double SwampsIterations();

        void UpdateProgress(int progress);
        void ChooseInput(double[] inputArray);
        void ShowSortResult(string[] methodName, int[] methodIterations, double[] methodTime, List<double[]> sortedArrays);
        bool IsIncreasing();

        double[] NumbersToSort();
        event EventHandler<EventArgs> AddData;
        event EventHandler<EventArgs> Sort;
    }



    // Модель. Основная часть работы программы происходит здесь
    class Model
    {
        private int fastIterations;
      
        public PlotModel CreateGraph(double interval, double downLimitation, double upLimitation, string function)
        {
            double limit = Convert.ToDouble(interval);
            double functionLimit = Convert.ToDouble(downLimitation);
            double upFunctionLimit = Convert.ToDouble(upLimitation);
            List<DataPoint> dot = new List<DataPoint>();

            var plotModel = new PlotModel { Title = "График функции f(x)" };


            var dataPoints = new List<double> { 0 };


            var absicc = new LineSeries {
                Title = "Абсцисс",
                Color = OxyColor.FromRgb(255, 0, 0), // Красный цвет
                StrokeThickness = 2
            };

            absicc.Points.Add(new DataPoint(-limit, 0));
            absicc.Points.Add(new DataPoint(limit, 0));

            var ordinate = new LineSeries {
                Title = "Ординат",
                Color = OxyColor.FromRgb(255, 0, 0), // Красный цвет
                StrokeThickness = 2,
            };

            ordinate.Points.Add(new DataPoint(0, limit));
            ordinate.Points.Add(new DataPoint(0, -limit));

            // Создаем серию точек графика
            var lineSeries = new LineSeries {
                Title = "f(x)",
                Color = OxyColor.FromRgb(0, 0, 255) // Синий цвет линии
            };

            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));

            int lowIndex = Convert.ToInt32(functionLimit);
            int upIndex = Convert.ToInt32(upFunctionLimit);
            for (double counterI = -lowIndex; counterI <= upIndex; ++counterI)
            {
                context.Variables["x"] = counterI;
                var expression = context.CompileGeneric<double>(function);
                double y = expression.Evaluate();
                lineSeries.Points.Add(new DataPoint(counterI, y));

            }

            // Добавляем все точки в серию
            lineSeries.Points.AddRange(dot);

            // Добавляем серию точек к модели графика
            plotModel.Series.Add(lineSeries);
            plotModel.Series.Add(ordinate);
            plotModel.Series.Add(absicc);

            return plotModel;
        }

        public (double, double) Dichotomy(string inputFunction, double leftLimitation, double rightLimitation, double epsilon)
        {
            double result = double.NaN;
            double currentResult = 0;
            double errorCheck = 0;
            double first = 0;
            double second = 0;

            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));

            while ((rightLimitation - leftLimitation) >= epsilon)
            {
                currentResult = (leftLimitation + rightLimitation) / 2;
                context.Variables["x"] = currentResult;
                var expression = context.CompileGeneric<double>(inputFunction);
                double position = expression.Evaluate();

                context.Variables["x"] = leftLimitation;
                expression = context.CompileGeneric<double>(inputFunction);
                var leftY = expression.Evaluate();
                first = leftY;

                context.Variables["x"] = rightLimitation;
                expression = context.CompileGeneric<double>(inputFunction);
                var rightY = expression.Evaluate();
                second = rightY;

                if (Math.Abs(position) == 0) // Найден точный корень
                {
                    result = currentResult;
                    return (result, errorCheck);
                }
                else if (leftY * position < 0) // Корень в левой половине интервала
                {
                    rightLimitation = currentResult;
                }
                else // Корень в правой половине интервала
                {
                    leftLimitation = currentResult;
                }
            }

            result = currentResult;

            if (first * second > 0)
            {
                errorCheck = 1;
            }
            else
            {
                errorCheck = 0;
            }

            return (result, errorCheck);
        }

        public (double, double) GoldenRatio(string inputExpression, double leftLimitation, double rightLimitation, double epsilon, bool choice = true)
        {
            double result = double.NaN;
            double functionResult = 0;
            double goldenRatio = (Math.Sqrt(5) + 1) / 2;
            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            if (!choice)
            {
                inputExpression = "-(" + inputExpression + ")";
            }

            double xFirst = rightLimitation - (rightLimitation - leftLimitation) / goldenRatio;
            double xSecond = leftLimitation + (rightLimitation - leftLimitation) / goldenRatio;
            double resultFirst = 0;
            double resultSecond = 0;


            while (Math.Abs(rightLimitation - leftLimitation) > epsilon)
            {
                context.Variables["x"] = xFirst;
                var expression = context.CompileGeneric<double>(inputExpression);
                resultFirst = expression.Evaluate();

                context.Variables["x"] = xSecond;
                expression = context.CompileGeneric<double>(inputExpression);
                resultSecond = expression.Evaluate();

                if (resultFirst < resultSecond)
                {
                    rightLimitation = xSecond;
                    xSecond = xFirst;
                    xFirst = rightLimitation - (rightLimitation - leftLimitation) / goldenRatio;
                }
                else
                {
                    leftLimitation = xFirst;
                    xFirst = xSecond;
                    xSecond = leftLimitation + (rightLimitation - leftLimitation) / goldenRatio;
                }
            }
            result = (leftLimitation + rightLimitation) / 2;
            context.Variables["x"] = result;
            var resultExpression = context.CompileGeneric<double>(inputExpression);
            functionResult = resultExpression.Evaluate();

            return (result, functionResult);
        }


        public (double, double, List<double[]>) Newton(string inputFunction, double inputApproximation, double epsilon, double step, double iterationCount, byte inputChoice)
        {
            double result = 0;
            double functionResult = 0;
            double current = inputApproximation;
            double next = 0;
            double derivative = 0;
            double secondDerivative = 0;
            byte choice = 1;
            List<double[]> array = new List<double[]>();
            double leftDerivative = 0;
            double rightDerivative = 0;
            choice = inputChoice;
            int innerCount = 0;

            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            context.Variables["x"] = current;
            var expression = context.CompileGeneric<double>(inputFunction);
            for (int iteration = 0; iteration < iterationCount; ++iteration)
            {
                switch (choice)
                {
                    case 1:
                        context.Variables["x"] = current;
                        double function = expression.Evaluate(); //Значение функции в x
                        derivative = NumericalDerivative(context, expression, current, step); //Численная производная

                        // Проверка на ноль
                        if (Math.Abs(derivative) < 1e-10)
                        {
                            return (double.NaN, double.NaN, array);
                        }
                        next = current - function / derivative;
                        context.Variables["x"] = next;
                        array.Add(new double[] { next, expression.Evaluate() });

                        if (Math.Abs(next - current) < epsilon)
                        {
                            result = next;
                            context.Variables["x"] = result;
                            expression = context.CompileGeneric<double>(inputFunction);
                            functionResult = expression.Evaluate();
                            break;
                        }

                        current = next;
                        ++innerCount;
                        break;
                    case 2:
                        context.Variables["x"] = current;
                        derivative = NumericalDerivative(context, expression, current, step); //Численная производная
                        secondDerivative = NumericalSecondDerivative(context, expression, current, step);

                        if (Math.Abs(secondDerivative) < 1e-10)
                        {
                            iteration = Convert.ToInt32(iterationCount);
                            return (double.NaN, 0, array);
                        }

                        next = current - derivative / secondDerivative;
                        context.Variables["x"] = next;
                        array.Add(new double[] { next, expression.Evaluate() });
                        leftDerivative = NumericalDerivative(context, expression, current - step, step);
                        rightDerivative = NumericalDerivative(context, expression, current + step, step);

                        if (Math.Abs(derivative) < epsilon && leftDerivative < 0 && rightDerivative > 0)
                        {
                            result = current;
                            context.Variables["x"] = result;
                            expression = context.CompileGeneric<double>(inputFunction);
                            functionResult = expression.Evaluate();
                            break;
                        }
                        else if (Math.Abs(derivative) < epsilon)
                        {
                            return (0, double.NaN, array);
                        }

                        ++innerCount;
                        current = next;


                        break;
                    case 3:
                        context.Variables["x"] = current;
                        derivative = NumericalDerivative(context, expression, current, step); //Численная производная
                        secondDerivative = NumericalSecondDerivative(context, expression, current, step);

                        if (Math.Abs(secondDerivative) < 1e-10)
                        {
                            iteration = Convert.ToInt32(iterationCount);
                            return (double.NaN, 0, array);
                        }

                        next = current - derivative / secondDerivative;
                        context.Variables["x"] = next;
                        array.Add(new double[] { next, expression.Evaluate() });
                        leftDerivative = NumericalDerivative(context, expression, current - step, step);
                        rightDerivative = NumericalDerivative(context, expression, current + step, step);

                        if (Math.Abs(derivative) < epsilon && leftDerivative > 0 && rightDerivative < 0)
                        {
                            result = current;
                            context.Variables["x"] = result;
                            expression = context.CompileGeneric<double>(inputFunction);
                            functionResult = expression.Evaluate();
                            break;
                        }
                        else if (Math.Abs(derivative) < epsilon)
                        {
                            return (0, double.NaN, array);
                        }

                        ++innerCount;
                        current = next;


                        break;
                    default:
                        break;
                }
                if (innerCount >= iterationCount && (result == 0 && functionResult == 0))
                {
                    return (double.NaN, double.NaN, array);
                }
            }

            return (result, functionResult, array);
        }

        public (double, double) Descent(string inputFunction, double inputApproximation, double epsilon, double step, double iterationCount, byte inputChoice, bool isWideAllowed)
        {
            double result = double.NaN;
            double functionResult = double.NaN;
            double startX = inputApproximation;
            double stepSize = step;
            double descentX = 0;
            double wideStep = 1;
            double safety = 0;

            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            context.Variables["x"] = startX;
            var expression = context.CompileGeneric<double>(inputFunction);
            double lowWideStep = inputApproximation - wideStep;
            double upWideStep = inputApproximation + wideStep;
            double leftWideDerivative = NumericalDerivative(context, expression, startX - wideStep, step);
            double rightWideDerivative = NumericalDerivative(context, expression, startX + wideStep, step);
            if (isWideAllowed)
            {
                do
                {
                    context.Variables["x"] = startX;
                    double wideValueOfFunction = expression.Evaluate();
                    context.Variables["x"] = lowWideStep;
                    double lowWideValueOfFunction = expression.Evaluate();
                    context.Variables["x"] = upWideStep;
                    double upWideValueOfFunction = expression.Evaluate();
                    switch (inputChoice)
                    {
                        case 2:
                            if (lowWideValueOfFunction < upWideValueOfFunction)
                            {
                                startX -= wideStep;
                            }
                            else if (lowWideValueOfFunction > upWideValueOfFunction)
                            {
                                startX += wideStep;
                            }
                            lowWideStep = startX - wideStep;
                            upWideStep = startX + wideStep;
                            break;
                        case 3:
                            if (lowWideValueOfFunction > upWideValueOfFunction)
                            {
                                startX -= wideStep;
                            }
                            else if (lowWideValueOfFunction < upWideValueOfFunction)
                            {
                                startX += wideStep;
                            }
                            lowWideStep = startX - wideStep;
                            upWideStep = startX + wideStep;
                            break;
                    }
                    leftWideDerivative = NumericalDerivative(context, expression, startX - wideStep, step);
                    rightWideDerivative = NumericalDerivative(context, expression, startX + wideStep, step);
                    ++safety;
                } while (leftWideDerivative * rightWideDerivative > 0 && safety < iterationCount);
            }


            if (safety == iterationCount)
            {
                startX = inputApproximation;
            }

            for (int iterationIndex = 0; iterationIndex < iterationCount; ++iterationIndex)
            {
                double currentX = startX;

                context.Variables["x"] = currentX;
                expression = context.CompileGeneric<double>(inputFunction);
                double valueOfFunction = expression.Evaluate();
                descentX = startX - stepSize;
                context.Variables["x"] = descentX;
                expression = context.CompileGeneric<double>(inputFunction);
                double valueOfLowerX = expression.Evaluate();
                descentX = startX + stepSize;
                context.Variables["x"] = descentX;
                expression = context.CompileGeneric<double>(inputFunction);
                double valueOfUpperX = expression.Evaluate();

                context.Variables["x"] = descentX;
                double innerValueOfFunction = expression.Evaluate();

                switch (inputChoice)
                {
                    case 2:
                        if (valueOfLowerX < valueOfUpperX)
                        {
                            currentX -= stepSize;
                        }
                        else if (valueOfLowerX > valueOfUpperX)
                        {
                            currentX += stepSize;
                        }

                        break;
                    case 3:
                        if (valueOfLowerX > valueOfUpperX)
                        {
                            currentX -= stepSize;
                        }
                        else if (valueOfLowerX < valueOfUpperX)
                        {
                            currentX += stepSize;
                        }

                        break;
                }


                startX = currentX;
                double leftDerivative = NumericalDerivative(context, expression, currentX - step, step);
                double rightDerivative = NumericalDerivative(context, expression, currentX + step, step);
                if ((Math.Abs(valueOfLowerX - valueOfFunction) < epsilon || Math.Abs(valueOfUpperX - valueOfFunction) < epsilon) && (leftDerivative * rightDerivative < 0))
                {
                    result = currentX;
                    context.Variables["x"] = result;
                    functionResult = expression.Evaluate();
                    break;
                }

            }
            return (result, functionResult);
        }

        double NumericalDerivative(ExpressionContext context, IGenericExpression<double> expression, double x, double step)
        {
            double h = step;
            context.Variables["x"] = x + h;
            double fxPlusH = expression.Evaluate();
            context.Variables["x"] = x - h;
            double fxMinusH = expression.Evaluate();
            return (fxPlusH - fxMinusH) / (2 * h); //Центральная разность (метод нахождения 1 производной)
        }

        double NumericalSecondDerivative(ExpressionContext context, IGenericExpression<double> expression, double x, double step)
        {
            double h = step;
            context.Variables["x"] = x + h;
            double fxPlusH = expression.Evaluate();
            context.Variables["x"] = x - h;
            double fxMinusH = expression.Evaluate();
            context.Variables["x"] = x;
            double fxOriginal = expression.Evaluate();
            return (fxPlusH - 2 * fxOriginal + fxMinusH) / (h * h); //Центральная разность (метод нахождения 2 производной)
        }


        public double[] ChooseInput(byte inputChoice, string pathToFile, int leftLimit, int rightLimit, bool IsNeedToDouble, int arraySize = 10)
        {
            double[] numbers = new double[arraySize];
            switch (inputChoice)
            {
                case 1:
                    numbers[0] = double.NaN;
                    return numbers;

                case 2:
                    Random random = new Random();
                    for (int randomIndex = 0; randomIndex < arraySize; ++randomIndex)
                    {
                        if (IsNeedToDouble)
                        {
                            numbers[randomIndex] = random.Next(-leftLimit, rightLimit) + random.NextDouble();
                        }
                        else
                        {
                            numbers[randomIndex] = random.Next(-leftLimit, rightLimit);
                        }
                        
                    }
                    return numbers;

                case 3:
                    if (pathToFile != "temporary")
                    {
                        if (pathToFile.Contains("xlsx"))  
                        {
                            using (FileStream file = new FileStream(pathToFile, FileMode.Open, FileAccess.Read))
                            {
                                IWorkbook workbook = new XSSFWorkbook(file);
                                ISheet sheet = workbook.GetSheetAt(0);
                                numbers = new double[sheet.LastRowNum + 1];

                                for (int excelIndex = 0; excelIndex <= sheet.LastRowNum; ++excelIndex)
                                {
                                    IRow currentrow = sheet.GetRow(excelIndex);
                                    if (currentrow != null)
                                    {
                                        ICell cell = currentrow.GetCell(0);
                                        if (cell != null)
                                        {
                                            numbers[excelIndex] = cell.NumericCellValue;
                                        }
                                    }

                                }
                            }
                        }
                        else if (pathToFile.Contains("txt")) 
                        {
                            string[] lines = File.ReadAllLines(pathToFile);
                            numbers = new double[lines.Length];
                            for (int inputIndex = 0;  inputIndex < lines.Length; ++inputIndex)
                            {
                                numbers[inputIndex] = Convert.ToDouble(lines[inputIndex]);
                            }
                        }
                        
                    }
                    return numbers;

                default:
                    int size = 100000;
                    numbers = new double[size];
                    Random test = new Random();
                    for (int randomIndex = 0; randomIndex < size; ++randomIndex)
                    {
                        numbers[randomIndex] = test.Next(int.MinValue, int.MaxValue) + test.NextDouble();
                    }
                    return numbers;
            }
        }

        public (string[], int[], double[], List<double[]>) Sorting(bool isBubbleActive, bool isInsertsActive, bool isFastActive, bool isShakeActive, bool isSwampActive, double swampIterations, double[] arrayToSort, bool isIncreasingSort)
        {
            string[] namesOfMethods = new string[5];
            int[] iterationsOfMethods = new int[5];
            double[] timeOfMethods = new double[5];
            List<double[]> sortedArrays = new List<double[]>();
            double[] array = new double[arrayToSort.Length];
            MakeNewMassive(arrayToSort, array);
            if (isBubbleActive)
            {
                var output = BubbleSort(array, isIncreasingSort);
                namesOfMethods[0] = output.Item1;
                iterationsOfMethods[0] = output.Item2;
                timeOfMethods[0] = output.Item3;
                MakeNewMassive(output.Item4, array);
                sortedArrays.Add(array.ToArray());
            }
            MakeNewMassive(arrayToSort, array);
            if (isInsertsActive)
            {
                var output = InsertsSort(array, isIncreasingSort);
                namesOfMethods[1] = output.Item1;
                iterationsOfMethods[1] = output.Item2;
                timeOfMethods[1] = output.Item3;
                MakeNewMassive(output.Item4, array);
                sortedArrays.Add(array.ToArray());
            }
            MakeNewMassive(arrayToSort, array);
            if (isFastActive)
            {
                namesOfMethods[2] = "Быстрая сортировка";
                var output = FastSort(array, isIncreasingSort);
                iterationsOfMethods[2] = output.Item1;
                timeOfMethods[2] = output.Item2;
                MakeNewMassive(output.Item3, array);
                sortedArrays.Add(array.ToArray());
            }
            MakeNewMassive(arrayToSort, array);
            if (isShakeActive)
            {
                var output = ShakeSort(array, isIncreasingSort);
                namesOfMethods[3] = output.Item1;
                iterationsOfMethods[3] = output.Item2;
                timeOfMethods[3] = output.Item3;
                MakeNewMassive(output.Item4, array);
                sortedArrays.Add(array.ToArray());
            }
            MakeNewMassive(arrayToSort, array);
            if (isSwampActive)
            {
                var output = SwampSort(array, isIncreasingSort, Convert.ToInt32(swampIterations));
                namesOfMethods[4] = output.Item1;
                iterationsOfMethods[4] = output.Item2;
                timeOfMethods[4] = output.Item3;
                MakeNewMassive(output.Item4, array);
                sortedArrays.Add(array.ToArray());
            }
            return (namesOfMethods, iterationsOfMethods, timeOfMethods, sortedArrays);
        }

        private (string, int, double, double[]) BubbleSort(double[] arrayToSort, bool isIncreasingSort)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string namesOfBubble = "Сортировка пузырьком";
            int iterationsOfBubble = 0;
            double timeOfBubble = 0;
            if (isIncreasingSort)
            {

                do
                {
                    for (int sortIndex = 0; sortIndex < arrayToSort.Length - 1; ++sortIndex)
                    {

                        if (arrayToSort[sortIndex] > arrayToSort[sortIndex + 1])
                        {
                            double temp = arrayToSort[sortIndex];
                            arrayToSort[sortIndex] = arrayToSort[sortIndex + 1];
                            arrayToSort[sortIndex + 1] = temp;
                        }

                    }
                    ++iterationsOfBubble;
                } while (!isSorted(arrayToSort, isIncreasingSort));

            }
            else
            {
                do
                {
                    for (int sortIndex = 0; sortIndex < arrayToSort.Length - 1; ++sortIndex)
                    {

                        if (arrayToSort[sortIndex] < arrayToSort[sortIndex + 1])
                        {
                            double temp = arrayToSort[sortIndex];
                            arrayToSort[sortIndex] = arrayToSort[sortIndex + 1];
                            arrayToSort[sortIndex + 1] = temp;
                        }

                    }
                    ++iterationsOfBubble;
                } while (!isSorted(arrayToSort, isIncreasingSort));
            }

            timer.Stop();
            timeOfBubble = timer.Elapsed.TotalSeconds;
            return (namesOfBubble, iterationsOfBubble, timeOfBubble, arrayToSort);
        }

        private (string, int, double, double[]) InsertsSort(double[] arrayToSort, bool isIncreasingSort)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string namesOfInserts = "Сортировка вставками";
            int iterationsOfInserts = 0;
            double timeOfInserts = 0;
            if (isIncreasingSort)
            {
                for (int index = 1; index < arrayToSort.Length; ++index)
                {
                    double key = arrayToSort[index];
                    int temp = index - 1;
                    while (temp >= 0 && arrayToSort[temp] > key)
                    {
                        arrayToSort[temp + 1] = arrayToSort[temp];
                        --temp;
                    }

                    arrayToSort[temp + 1] = key;
                    ++iterationsOfInserts;
                }

            }
            else
            {
                for (int index = 1; index < arrayToSort.Length; ++index)
                {
                    double key = arrayToSort[index];
                    int temp = index - 1;
                    while (temp >= 0 && arrayToSort[temp] < key)
                    {
                        arrayToSort[temp + 1] = arrayToSort[temp];
                        --temp;
                    }

                    arrayToSort[temp + 1] = key;
                    ++iterationsOfInserts;
                }
            }

            timer.Stop();
            timeOfInserts = timer.Elapsed.TotalSeconds;
            return (namesOfInserts, iterationsOfInserts, timeOfInserts, arrayToSort);
        }

        
        private (int, double, double[]) FastSort(double[] arrayToSort, bool isIncreasingSort)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            double timeOfFast;
            fastIterations = 0;
            Sort(arrayToSort, isIncreasingSort, 0, arrayToSort.Length - 1);
            timer.Stop();
            timeOfFast = timer.Elapsed.TotalSeconds;
            return (fastIterations, timeOfFast, arrayToSort);
        }
         
        private void Sort(double[] array,  bool isIncreasingSort, int lowIndex, int upIndex)
        {
            if (lowIndex < upIndex)
            {
                int pivotIndex = Partition(array, isIncreasingSort, lowIndex, upIndex);

                Sort(array, isIncreasingSort, lowIndex, pivotIndex - 1);
                Sort(array, isIncreasingSort, pivotIndex + 1, upIndex);
            }
            ++fastIterations;
        }
        private static int Partition(double[] array, bool isIncreasingSort, int left, int right )
        {
            double pivot = array[right];
            int index = left - 1;

            for (int sortIndex = left; sortIndex < right; ++sortIndex)
            {
                if (isIncreasingSort ? array[sortIndex] <= pivot : array[sortIndex] >= pivot)
                {
                    ++index;
                    double numberOne = array[index];
                    double numberTwo = array[sortIndex];

                    array[index] = numberTwo;
                    array[sortIndex] = numberOne;                  
                }
            }
            double tempOne = array[index + 1];
            double tempTwo = array[right];

            array[index + 1] = tempTwo;
            array[right] = tempOne;

            return index + 1;
        }

        private (string, int, double, double[]) ShakeSort(double[] arrayToSort, bool isIncreasingSort)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string namesOfShake = "Шейкерная сортировка";
            int iterationsOfShake = 0;
            double timeOfShake = 0;
            if (isIncreasingSort)
            {
                do
                {

                    for (int sortIndex = 0; sortIndex < arrayToSort.Length - 1; ++sortIndex)
                    {

                        if (arrayToSort[sortIndex] > arrayToSort[sortIndex + 1])
                        {
                            double temp = arrayToSort[sortIndex];
                            arrayToSort[sortIndex] = arrayToSort[sortIndex + 1];
                            arrayToSort[sortIndex + 1] = temp;

                        }

                    }

                    for (int ReverseSortIndex = arrayToSort.Length - 1; ReverseSortIndex > 0; --ReverseSortIndex)
                    {

                        if (arrayToSort[ReverseSortIndex - 1] > arrayToSort[ReverseSortIndex])
                        {
                            double temp = arrayToSort[ReverseSortIndex - 1];
                            arrayToSort[ReverseSortIndex - 1] = arrayToSort[ReverseSortIndex];
                            arrayToSort[ReverseSortIndex] = temp;

                        }

                    }
                    ++iterationsOfShake;
                } while (!isSorted(arrayToSort, isIncreasingSort));
            }
            else
            {
                do
                {

                    for (int sortIndex = 0; sortIndex < arrayToSort.Length - 1; ++sortIndex)
                    {

                        if (arrayToSort[sortIndex] < arrayToSort[sortIndex + 1])
                        {
                            double temp = arrayToSort[sortIndex];
                            arrayToSort[sortIndex] = arrayToSort[sortIndex + 1];
                            arrayToSort[sortIndex + 1] = temp;

                        }

                    }

                    for (int ReverseSortIndex = arrayToSort.Length - 1; ReverseSortIndex > 0; --ReverseSortIndex)
                    {

                        if (arrayToSort[ReverseSortIndex - 1] < arrayToSort[ReverseSortIndex])
                        {
                            double temp = arrayToSort[ReverseSortIndex - 1];
                            arrayToSort[ReverseSortIndex - 1] = arrayToSort[ReverseSortIndex];
                            arrayToSort[ReverseSortIndex] = temp;

                        }

                    }
                    ++iterationsOfShake;
                } while (!isSorted(arrayToSort, isIncreasingSort));
            }

            timer.Stop();
            timeOfShake = timer.Elapsed.TotalSeconds;
            return (namesOfShake, iterationsOfShake, timeOfShake, arrayToSort);
        }

        private (string, int, double, double[]) SwampSort(double[] arrayToSort, bool isIncreasingSort, int swampIterations)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string namesOfSwamp = "Болотная сортировка";
            int iterationsOfSwamp = 0;
            double timeOfSwamp = 0;
            while (!isSorted(arrayToSort, isIncreasingSort) && iterationsOfSwamp < swampIterations)
            {

                Random generator = new Random();

                for (int index = 0; index < arrayToSort.Length; ++index)
                {

                    int randomPosition = generator.Next(arrayToSort.Length);
                    double tempVariable = arrayToSort[index];
                    arrayToSort[index] = arrayToSort[randomPosition];
                    arrayToSort[randomPosition] = tempVariable;

                }
                ++iterationsOfSwamp;
            };

            timer.Stop();
            timeOfSwamp = timer.Elapsed.TotalSeconds;
            return (namesOfSwamp, iterationsOfSwamp, timeOfSwamp, arrayToSort);
        }

        private bool isSorted(double[] data, bool isIncreasing)
        {
            bool sorted = true;
            if (isIncreasing)
            {
                for (int index = 1; index < data.Length; ++index)
                {
                    if (data[index] < data[index - 1])
                    {
                        sorted = false;
                    }
                }
            }
            else
            {
                for (int index = 1; index < data.Length; ++index)
                {
                    if (data[index] > data[index - 1])
                    {
                        sorted = false;
                    }
                }
            }
            return sorted;

        }

        private double[] MakeNewMassive(double[] data, double[] output)
        {
            for (int index = 0; index < data.Length; ++index)
            {
                output[index] = data[index];
            }
            return output;
        }

        private int FindStartPoint(double[] arrayToSort, bool isIncreasingSort, int lowIndex, int upIndex)
        {
            double pivot = arrayToSort[upIndex];
            int temp = (lowIndex - 1);
            for (int pivotIndex = 0; pivotIndex < upIndex; ++pivotIndex)
            {
                if (arrayToSort[pivotIndex] < pivot)
                {
                    ++temp;
                }

                double otherTemp = arrayToSort[temp];
                arrayToSort[temp + 1] = arrayToSort[upIndex];
                arrayToSort[upIndex] = otherTemp;
            }
            return temp + 1;
        }
    }


    // Презентер. Извлекает данные из модели, передает в вид. Обрабатывает события
    class Presenter
    {
        private IView mainView;
        private ISortView sortView;
        private Model model;

        public Presenter(IView inputView)
        {
            mainView = inputView;
            model = new Model();

            mainView.StartDichotomy += new EventHandler<EventArgs>(Dichotomy);
            mainView.CreateGraph += new EventHandler<EventArgs>(CreateGraph);
            mainView.StartGoldenRatio += new EventHandler<EventArgs>(GoldenRatio);
            mainView.StartNewton += new EventHandler<EventArgs>(Newton);
            mainView.StartDescent += new EventHandler<EventArgs>(Descent);
        }

        public Presenter(ISortView inputView)
        {
            sortView = inputView;
            model = new Model();

            sortView.AddData += new EventHandler<EventArgs>(AddData);
            sortView.Sort += new EventHandler<EventArgs>(Sort);
        }


        private void AddData(object sender, EventArgs inputEvent)
        {
            var output = model.ChooseInput(sortView.StartInput(), sortView.PathToFile(), sortView.leftInterval(), sortView.rightInterval(), sortView.IsDouble(), sortView.ArraySizeToRandom());
            sortView.ChooseInput(output);
        }

        private void Sort(object sender, EventArgs inputEvent)
        {
            var output = model.Sorting(sortView.IsActiveBubble(), sortView.IsActiveInserts(), sortView.IsActiveFast(), sortView.IsActiveShake(), sortView.IsActiveSwamp(), sortView.SwampsIterations(), sortView.NumbersToSort(), sortView.IsIncreasing());
            sortView.ShowSortResult(output.Item1, output.Item2, output.Item3, output.Item4);
        }

        private void Newton(object sender, EventArgs inputEvent)
        {
            var output = model.Newton(mainView.returnFunction(), mainView.firstSide(), mainView.epsilon(), mainView.secondSide(), mainView.iterationCount(), mainView.Choice());
            mainView.ShowResult(output.Item1, output.Item2);
            mainView.UpdateGraph(output.Item3);
        }

        private void Dichotomy(object sender, EventArgs inputEvent)
        {
            var output = model.Dichotomy(mainView.returnFunction(), mainView.firstSide(), mainView.secondSide(), mainView.epsilon());
            mainView.ShowResult(output.Item1, output.Item2);
        }
        private void CreateGraph(object sender, EventArgs inputEvent)
        {
            var output = model.CreateGraph(mainView.Interval(), mainView.lowLimit(), mainView.upLimit(), mainView.returnFunction());
            mainView.ShowGraph(output);
        }

        private void GoldenRatio(object sender, EventArgs inputEvent)
        {
            var output = model.GoldenRatio(mainView.returnFunction(), mainView.firstSide(), mainView.secondSide(), mainView.epsilon(), mainView.MinimumOrMaximum());
            mainView.ShowResult(output.Item1, output.Item2);
        }

        private void Descent(object sender, EventArgs inputEvent)
        {
            var output = model.Descent(mainView.returnFunction(), mainView.firstSide(), mainView.epsilon(), mainView.secondSide(), mainView.iterationCount(), mainView.Choice(), mainView.MinimumOrMaximum());
            mainView.ShowResult(output.Item1, output.Item2);
        }
    }

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

