/* Title:           Vehicle In Yard DLL
 * Date:            6-22-17
 * Author:          Terry Holmes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace VehicleInYardDLL
{
    public class VehicleInYardClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        VehiclesInYardDataSet aVehiclesInYardDataSet;
        VehiclesInYardDataSetTableAdapters.vehiclesinyardTableAdapter aVehiclesInYardTableAdapter;

        InsertVehicleInYardEntryTableAdapters.QueriesTableAdapter aInsertVehicleInYardEntryTableAdapter;

        FindVehiclesInYardByDateRangeDataSet aFindVehiclesInYardByDateRangeDataSet;
        FindVehiclesInYardByDateRangeDataSetTableAdapters.FindVehiclesInYardByDateRangeTableAdapter aFindVehiclesInYardByDateRangeTableAdapter;

        FindVehiclesInYardByVehicleIDAndDateRangeDataSet aFindVehiclesInYardByVehicleIDAndDateRangeDataSet;
        FindVehiclesInYardByVehicleIDAndDateRangeDataSetTableAdapters.FindVehiclesInYardByVehicleIDAndDateRangeTableAdapter aFindVehiclesInYardByVehicleIDAndDateRangeTableAdapter;

        FindVehiclesInYardVehicleIDDateMatchDataSet aFindVehiclesInYardVehicleIDDateMatchDataSet;
        FindVehiclesInYardVehicleIDDateMatchDataSetTableAdapters.FindVehiclesInYardVehicleIDDateMatchTableAdapter aFindVehiclesInyardVehicleIDDateMatchTableAdapter;

        FindVehiclesInYardSimplyDataSet aFindVehiclesInYardSimplyDataSet;
        FindVehiclesInYardSimplyDataSetTableAdapters.FindVehiclesInYardSimpleTableAdapter aFindVehiclesInYardSimplyTableAdapter;

        FindVehiclesInYardSummaryDataSet aFindVehiclesInYardSummaryDataSet;
        FindVehiclesInYardSummaryDataSetTableAdapters.FindVehiclesInYardSummaryTableAdapter aFindVehiclesInYardSummaryTableAdapter;

        public FindVehiclesInYardSummaryDataSet FindVehiclesInYardSummary(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehiclesInYardSummaryDataSet = new FindVehiclesInYardSummaryDataSet();
                aFindVehiclesInYardSummaryTableAdapter = new FindVehiclesInYardSummaryDataSetTableAdapters.FindVehiclesInYardSummaryTableAdapter();
                aFindVehiclesInYardSummaryTableAdapter.Fill(aFindVehiclesInYardSummaryDataSet.FindVehiclesInYardSummary, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Yard Class // Find Vehicles In Yard Summary " + Ex.Message);
            }

            return aFindVehiclesInYardSummaryDataSet;
        }
        public FindVehiclesInYardSimplyDataSet FindVehiclesInYardSimply(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehiclesInYardSimplyDataSet = new FindVehiclesInYardSimplyDataSet();
                aFindVehiclesInYardSimplyTableAdapter = new FindVehiclesInYardSimplyDataSetTableAdapters.FindVehiclesInYardSimpleTableAdapter();
                aFindVehiclesInYardSimplyTableAdapter.Fill(aFindVehiclesInYardSimplyDataSet.FindVehiclesInYardSimple, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Yard Class // Find Vehicles In Yard Simply " + Ex.Message);
            }

            return aFindVehiclesInYardSimplyDataSet;
        }
        public FindVehiclesInYardVehicleIDDateMatchDataSet FindVehiclesInYardVehicleIDDateMatch(int intVehicleID, DateTime datTransactionDate)
        {

            try
            {
                aFindVehiclesInYardVehicleIDDateMatchDataSet = new FindVehiclesInYardVehicleIDDateMatchDataSet();
                aFindVehiclesInyardVehicleIDDateMatchTableAdapter = new FindVehiclesInYardVehicleIDDateMatchDataSetTableAdapters.FindVehiclesInYardVehicleIDDateMatchTableAdapter();
                aFindVehiclesInyardVehicleIDDateMatchTableAdapter.Fill(aFindVehiclesInYardVehicleIDDateMatchDataSet.FindVehiclesInYardVehicleIDDateMatch, intVehicleID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Yard Class // Find Vehicles In Yard Vehicle ID Date Match " + Ex.Message);
            }

            return aFindVehiclesInYardVehicleIDDateMatchDataSet;
        }
        public FindVehiclesInYardByVehicleIDAndDateRangeDataSet FindVehiclesInYardByVehicleIDAndDateRange(int intVehicleID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehiclesInYardByVehicleIDAndDateRangeDataSet = new FindVehiclesInYardByVehicleIDAndDateRangeDataSet();
                aFindVehiclesInYardByVehicleIDAndDateRangeTableAdapter = new FindVehiclesInYardByVehicleIDAndDateRangeDataSetTableAdapters.FindVehiclesInYardByVehicleIDAndDateRangeTableAdapter();
                aFindVehiclesInYardByVehicleIDAndDateRangeTableAdapter.Fill(aFindVehiclesInYardByVehicleIDAndDateRangeDataSet.FindVehiclesInYardByVehicleIDAndDateRange, intVehicleID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Yard Class // Find Vehicles In Yard By Vehicle ID And Date Range " + Ex.Message);
            }

            return aFindVehiclesInYardByVehicleIDAndDateRangeDataSet;
        }
        public FindVehiclesInYardByDateRangeDataSet FindVehiclesInYardByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehiclesInYardByDateRangeDataSet = new FindVehiclesInYardByDateRangeDataSet();
                aFindVehiclesInYardByDateRangeTableAdapter = new FindVehiclesInYardByDateRangeDataSetTableAdapters.FindVehiclesInYardByDateRangeTableAdapter();
                aFindVehiclesInYardByDateRangeTableAdapter.Fill(aFindVehiclesInYardByDateRangeDataSet.FindVehiclesInYardByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Yard Class // Find Vehicles In Yard By Date Range " + Ex.Message);
            }

            return aFindVehiclesInYardByDateRangeDataSet;
        }
        public bool InsertVehicleInYard(DateTime datTransactionDate, int intVehicleID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertVehicleInYardEntryTableAdapter = new InsertVehicleInYardEntryTableAdapters.QueriesTableAdapter();
                aInsertVehicleInYardEntryTableAdapter.InsertVehicleInYard(datTransactionDate, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle In Yard Class // Insert Vehicle In Yard " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public VehiclesInYardDataSet GetVehiclesInYardInfo()
        {
            try
            {
                aVehiclesInYardDataSet = new VehiclesInYardDataSet();
                aVehiclesInYardTableAdapter = new VehiclesInYardDataSetTableAdapters.vehiclesinyardTableAdapter();
                aVehiclesInYardTableAdapter.Fill(aVehiclesInYardDataSet.vehiclesinyard);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Yard Class // Get Vehicles In Yard Info " + Ex.Message);
            }

            return aVehiclesInYardDataSet;
        }
        public void UpdateVehiclesInYardDB(VehiclesInYardDataSet aVehiclesInYardDataSet)
        {
            try
            {
                aVehiclesInYardTableAdapter = new VehiclesInYardDataSetTableAdapters.vehiclesinyardTableAdapter();
                aVehiclesInYardTableAdapter.Update(aVehiclesInYardDataSet.vehiclesinyard);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicles In Yard Class // Update Vehicles In Yard DB " + Ex.Message);
            }
        }
    }
}
