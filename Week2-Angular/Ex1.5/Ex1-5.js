async function fetchStockData() {
    const apiKey = "K37Y17GG58VDHGBT";
    const apiUrl = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=MSFT&interval=5min&apikey="+apiKey;
    try {
        const response = await fetch(apiUrl);

        if (!response.ok) {
            throw new Error("HTTP error! Status: ${response.status}");
        }
        const data = await response.json();
        return data;
    } catch (error) {
        console.error("Error fetching stock data:", error.message);
    }
};


fetchStockData()
    .then((result) => {
        console.log("Response:", result);        
    })
    .catch((error) => {

        console.error("Error in promise chain:", error);
    });
