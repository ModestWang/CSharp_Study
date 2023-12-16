using Machine_Learning;

var input = Console.ReadLine();

//// Add input data
//var sampleData_1 = new MyMLModel.ModelInput()
//{
//    Col0 = (input == "" || input == null) ? "I am happy." : input
//};

//// Load model and predict output of sample data
//var result_1 = MyMLModel.Predict(sampleData_1);

//// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
//var sentiment_1 = result_1.PredictedLabel == 1 ? "Positive" : "Negative";
//Console.WriteLine($"Text: {sampleData_1.Col0}\nSentiment: {sentiment_1}");

//Load sample data
var sampleData_2 = new MLModelDemo.ModelInput()
{
    Col0 = (input == "" || input == null) ? @"Good case, Excellent value." : input,
};

//Load model and predict output
var result_2 = MLModelDemo.Predict(sampleData_2);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
var sentiment_2 = result_2.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData_2.Col0}\nSentiment: {sentiment_2}");

