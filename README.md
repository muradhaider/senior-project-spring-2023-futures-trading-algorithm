# Futures Trading Algorithm 
Murad Haider: m_haider3@u.pacific.edu

# Project Description
The Futures Trading Algorithm is a computer program designed to help traders trade futures markets more effectively. The algorithm uses technical analysis to identify trends and market conditions, and automatically executes trades based on these signals. The system is based on an object-oriented design and is built on top of the NinjaTrader 8 platform.
The algorithm relies on a combination of EMA and VMA crosses, along with ninzaRenko candle types, to filter out chop and catch high-frequency trends. To reduce the number of trades taken in choppy markets, the algorithm will use these specific candle types and dynamically adjusts the indicators based on market conditions. The trading strategy is designed to run in real-time using historical market data, and can be used with a prop firm account.
Overall, the Futures Trading Algorithm provides traders with a powerful tool for automating their trading strategy and taking advantage of opportunities in the futures market. This will also include an easily changeable profit goal and time condition allowing users to change the profit goal and time condition in order to ensure we only trade to a certain goal on the day and within certain times such as market open to market close. 
# Project Components
1. Hardware: A computer with Windows 10 or higher.
2. Software: 

    a. NinjaTrader 8 64-bit software.

    b. Rithmic Trader software for monitoring the prop firm account.


3. Prop Firm Account: We will need to have access to a prop firm account to connect to our   system and enable the algorithm to execute trades.
4. Strategy Builder: We will use the NinjaTrader 8 Strategy Builder to create and customize our trading strategy.
5. NinzaRenkos (candle type free download)
6. ATR Trailing Stop Indicator (indicator free download)
# How to run the Futures Trading Algorithm
Launch the Rithmic platform and sign in using the credentials provided by the prop firm.
Launch NinjaTrader and connect it to the Rithmic platform using the same credentials.
Import the trading strategy by going to the Import tab and selecting the appropriate file.
Open the chart you wish to apply the strategy to.
Select the Strategies button and enable the strategy you want to apply.
The algorithm will automatically apply the trading signals to the market data and execute trades based on the predetermined entry and exit conditions.

#Special Notes
I have mnade some adjustments and finalized some of the things we will be using. I removed the UniRenkos as I have identified that for this strategy the ninzaRenkos do a much better job of filtering the trend and chop. There is also no need for stochastic conditions as they are not smooth and lag behind the conditions for entry so using them is not as viable as I had thought. We also included an ATR trailing stop which is subject to change with a little more testing but is the best for the current strategy optimization. 

