#region Using declarations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;
using NinjaTrader.Cbi;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Gui.Tools;
using NinjaTrader.Data;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;
using NinjaTrader.NinjaScript.Indicators;
using NinjaTrader.NinjaScript.DrawingTools;
#endregion

//This namespace holds Strategies in this folder and is required. Do not change it. 
namespace NinjaTrader.NinjaScript.Strategies
{
	public class test_2023_02_21_0 : Strategy
	{
		private Stochastics Stochastics1;
		private Stochastics Stochastics2;

		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description									= @"Enter the description for your new custom Strategy here.";
				Name										= "test_2023_02_21_0";
				Calculate									= Calculate.OnBarClose;
				EntriesPerDirection							= 1;
				EntryHandling								= EntryHandling.AllEntries;
				IsExitOnSessionCloseStrategy				= true;
				ExitOnSessionCloseSeconds					= 30;
				IsFillLimitOnTouch							= false;
				MaximumBarsLookBack							= MaximumBarsLookBack.TwoHundredFiftySix;
				OrderFillResolution							= OrderFillResolution.Standard;
				Slippage									= 0;
				StartBehavior								= StartBehavior.WaitUntilFlat;
				TimeInForce									= TimeInForce.Gtc;
				TraceOrders									= false;
				RealtimeErrorHandling						= RealtimeErrorHandling.StopCancelClose;
				StopTargetHandling							= StopTargetHandling.PerEntryExecution;
				BarsRequiredToTrade							= 20;
				// Disable this property for performance gains in Strategy Analyzer optimizations
				// See the Help Guide for additional information
				IsInstantiatedOnEachOptimizationIteration	= true;
			}
			else if (State == State.Configure)
			{
			}
			else if (State == State.DataLoaded)
			{				
				Stochastics1				= Stochastics(Close, 7, 14, 9);
				Stochastics2				= Stochastics(Close, 7, 14, 9);
				Stochastics1.Plots[0].Brush = Brushes.OrangeRed;
				Stochastics1.Plots[1].Brush = Brushes.Orchid;
				AddChartIndicator(Stochastics1);
				SetTrailStop(@"boom", CalculationMode.Ticks, 20, false);
			}
		}

		protected override void OnBarUpdate()
		{
			if (BarsInProgress != 0) 
				return;

			if (CurrentBars[0] < 1)
				return;

			 // Set 1
			
			
			if ((Stochastics1.K[0] > 20)
				 && (Stochastics1.D[0] < 80)
				 && (Stochastics1.K[0] < Stochastics2.D[0]))
			{
				EnterLong(Convert.ToInt32(DefaultQuantity), @"boom");
			}
			
			 // Set 2
			if ((Stochastics1.K[0] < 20)
				 && (Stochastics1.D[0] > 80)
				 && (Stochastics1.K[0] > Stochastics2.D[0]))
			{
				EnterShort(Convert.ToInt32(DefaultQuantity), @"boom");
			}
			
			 // Set 3
			if (MarketPosition.Long == MarketPosition.Long)
			{
				ExitLong(Convert.ToInt32(DefaultQuantity), @"boom", @"boom");
			}
			
			 // Set 4
			if (MarketPosition.Short == MarketPosition.Short)
			{
				ExitShort(Convert.ToInt32(DefaultQuantity), @"boom", @"boom");
			}
			
		}
	}
}
