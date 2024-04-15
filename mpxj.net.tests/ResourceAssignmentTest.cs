using System;
using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class ResourceAssignmentTest
    {
        [Test]
        public void PropertyGetTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);
            foreach (var assignment in project.ResourceAssignments)
            {
                TestResourceAssignment(assignment);
            }
        }

        private void TestResourceAssignment(ResourceAssignment assignment)
        {
            Assert.Multiple(() =>
            {
                var notesObject = (Notes)assignment.Get(TaskField.Notes);
                var notes = notesObject == null ? "" : notesObject.ToString();

                Assert.That(assignment.Start, Is.EqualTo(assignment.Get(AssignmentField.Start)));

                //Assert.That(assignment.Duration1Units, Is.EqualTo(assignment.Get(AssignmentField.Duration1Units)));
                //Assert.That(assignment.Duration2Units, Is.EqualTo(assignment.Get(AssignmentField.Duration2Units)));
                //Assert.That(assignment.Duration3Units, Is.EqualTo(assignment.Get(AssignmentField.Duration3Units)));
                //Assert.That(assignment.Duration4Units, Is.EqualTo(assignment.Get(AssignmentField.Duration4Units)));
                //Assert.That(assignment.Duration5Units, Is.EqualTo(assignment.Get(AssignmentField.Duration5Units)));
                //Assert.That(assignment.Duration6Units, Is.EqualTo(assignment.Get(AssignmentField.Duration6Units)));
                //Assert.That(assignment.Duration7Units, Is.EqualTo(assignment.Get(AssignmentField.Duration7Units)));
                //Assert.That(assignment.Duration8Units, Is.EqualTo(assignment.Get(AssignmentField.Duration8Units)));
                //Assert.That(assignment.Duration9Units, Is.EqualTo(assignment.Get(AssignmentField.Duration9Units)));
                //Assert.That(assignment.Duration10Units, Is.EqualTo(assignment.Get(AssignmentField.Duration10Units)));
                Assert.That(assignment.ActualCost, Is.EqualTo(assignment.Get(AssignmentField.ActualCost)));
                Assert.That(assignment.ActualWork, Is.EqualTo(assignment.Get(AssignmentField.ActualWork)));
                Assert.That(assignment.Cost, Is.EqualTo(assignment.Get(AssignmentField.Cost)));
                Assert.That(assignment.Delay, Is.EqualTo(assignment.Get(AssignmentField.AssignmentDelay)));
                Assert.That(assignment.VariableRateUnits, Is.EqualTo(assignment.Get(AssignmentField.VariableRateUnits)));
                //Assert.That(assignment.AssignmentUnits, Is.EqualTo(assignment.Get(AssignmentField.AssignmentUnits)));
                Assert.That(assignment.Work, Is.EqualTo(assignment.Get(AssignmentField.Work)));
                Assert.That(assignment.BaselineStart, Is.EqualTo(assignment.Get(AssignmentField.BaselineStart)));
                Assert.That(assignment.ActualStart, Is.EqualTo(assignment.Get(AssignmentField.ActualStart)));
                Assert.That(assignment.BaselineFinish, Is.EqualTo(assignment.Get(AssignmentField.BaselineFinish)));
                Assert.That(assignment.ActualFinish, Is.EqualTo(assignment.Get(AssignmentField.ActualFinish)));
                Assert.That(assignment.BaselineWork, Is.EqualTo(assignment.Get(AssignmentField.BaselineWork)));
                Assert.That(assignment.OvertimeWork, Is.EqualTo(assignment.Get(AssignmentField.OvertimeWork)));
                Assert.That(assignment.BaselineCost, Is.EqualTo(assignment.Get(AssignmentField.BaselineCost)));
                Assert.That(assignment.WorkContour, Is.EqualTo(assignment.Get(AssignmentField.WorkContour)));
                Assert.That(assignment.RemainingWork, Is.EqualTo(assignment.Get(AssignmentField.RemainingWork)));
                //Assert.That(assignment.LevelingDelayUnits, Is.EqualTo(assignment.Get(AssignmentField.LevelingDelayUnits)));
                Assert.That(assignment.LevelingDelay, Is.EqualTo(assignment.Get(AssignmentField.LevelingDelay)));
                Assert.That(assignment.UniqueID, Is.EqualTo(assignment.Get(AssignmentField.UniqueId)));
                Assert.That(assignment.TaskUniqueID, Is.EqualTo(assignment.Get(AssignmentField.TaskUniqueId)));
                Assert.That(assignment.ResourceUniqueID, Is.EqualTo(assignment.Get(AssignmentField.ResourceUniqueId)));
                //Assert.That(assignment.TimephasedWork, Is.EqualTo(assignment.Get(AssignmentField.TimephasedWork)));
                //Assert.That(assignment.TimephasedActualWork, Is.EqualTo(assignment.Get(AssignmentField.TimephasedActualWork)));
                //Assert.That(assignment.TimephasedActualOvertimeWork, Is.EqualTo(assignment.Get(AssignmentField.TimephasedActualOvertimeWork)));

                //Assert.That(assignment.GetTimephasedBaselineWork(0), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaselineWork)));
                //Assert.That(assignment.GetTimephasedBaselineWork(1), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline1Work)));
                //Assert.That(assignment.GetTimephasedBaselineWork(2), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline2Work)));
                //Assert.That(assignment.GetTimephasedBaselineWork(3), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline3Work)));
                //Assert.That(assignment.GetTimephasedBaselineWork(4), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline4Work)));
                //Assert.That(assignment.GetTimephasedBaselineWork(5), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline5Work)));
                //Assert.That(assignment.GetTimephasedBaselineWork(6), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline6Work)));
                //Assert.That(assignment.GetTimephasedBaselineWork(7), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline7Work)));
                //Assert.That(assignment.GetTimephasedBaselineWork(8), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline8Work)));
                //Assert.That(assignment.GetTimephasedBaselineWork(9), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline9Work)));
                //Assert.That(assignment.GetTimephasedBaselineWork(10), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline10Work)));

                //Assert.That(assignment.GetTimephasedBaselineCost(0), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaselineCost)));
                //Assert.That(assignment.GetTimephasedBaselineCost(1), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline1Cost)));
                //Assert.That(assignment.GetTimephasedBaselineCost(2), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline2Cost)));
                //Assert.That(assignment.GetTimephasedBaselineCost(3), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline3Cost)));
                //Assert.That(assignment.GetTimephasedBaselineCost(4), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline4Cost)));
                //Assert.That(assignment.GetTimephasedBaselineCost(5), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline5Cost)));
                //Assert.That(assignment.GetTimephasedBaselineCost(6), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline6Cost)));
                //Assert.That(assignment.GetTimephasedBaselineCost(7), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline7Cost)));
                //Assert.That(assignment.GetTimephasedBaselineCost(8), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline8Cost)));
                //Assert.That(assignment.GetTimephasedBaselineCost(9), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline9Cost)));
                //Assert.That(assignment.GetTimephasedBaselineCost(10), Is.EqualTo(assignment.Get(AssignmentField.TimephasedBaseline10Cost)));

                //Assert.That(assignment.TaskID, Is.EqualTo(assignment.Get(AssignmentField.TaskId)));
                //Assert.That(assignment.ResourceID, Is.EqualTo(assignment.Get(AssignmentField.ResourceId)));
                //Assert.That(assignment.TaskName, Is.EqualTo(assignment.Get(AssignmentField.TaskName)));
                //Assert.That(assignment.ResourceName, Is.EqualTo(assignment.Get(AssignmentField.ResourceName)));
                Assert.That(assignment.RegularWork, Is.EqualTo(assignment.Get(AssignmentField.RegularWork)));
                Assert.That(assignment.ActualOvertimeWork, Is.EqualTo(assignment.Get(AssignmentField.ActualOvertimeWork)));
                Assert.That(assignment.RemainingOvertimeWork, Is.EqualTo(assignment.Get(AssignmentField.RemainingOvertimeWork)));
                //Assert.That(assignment.Peak, Is.EqualTo(assignment.Get(AssignmentField.Peak)));
                Assert.That(assignment.OvertimeCost, Is.EqualTo(assignment.Get(AssignmentField.OvertimeCost)));
                Assert.That(assignment.RemainingCost, Is.EqualTo(assignment.Get(AssignmentField.RemainingCost)));
                Assert.That(assignment.ActualOvertimeCost, Is.EqualTo(assignment.Get(AssignmentField.ActualOvertimeCost)));
                Assert.That(assignment.RemainingOvertimeCost, Is.EqualTo(assignment.Get(AssignmentField.RemainingOvertimeCost)));
                Assert.That(assignment.BCWS, Is.EqualTo(assignment.Get(AssignmentField.BCWS)));
                Assert.That(assignment.BCWP, Is.EqualTo(assignment.Get(AssignmentField.BCWP)));
                Assert.That(assignment.ACWP, Is.EqualTo(assignment.Get(AssignmentField.ACWP)));
                Assert.That(assignment.SV, Is.EqualTo(assignment.Get(AssignmentField.SV)));
                Assert.That(assignment.CostVariance, Is.EqualTo(assignment.Get(AssignmentField.CostVariance)));
                Assert.That(assignment.PercentageWorkComplete, Is.EqualTo(assignment.Get(AssignmentField.PercentWorkComplete)));
                //Assert.That(assignment.Project, Is.EqualTo(assignment.Get(AssignmentField.Project)));
                Assert.That(assignment.Notes, Is.EqualTo(notes));
                Assert.That(assignment.Confirmed, Is.EqualTo(assignment.Get(AssignmentField.Confirmed)));
                Assert.That(assignment.ResponsePending, Is.EqualTo(assignment.Get(AssignmentField.ResponsePending)));
                Assert.That(assignment.UpdateNeeded, Is.False);
                Assert.That(assignment.TeamStatusPending, Is.False);
                Assert.That(assignment.CostRateTableIndex, Is.EqualTo(assignment.Get(AssignmentField.CostRateTable)));

                Assert.That(assignment.GetText(1), Is.EqualTo(assignment.Get(AssignmentField.Text1)));
                Assert.That(assignment.GetText(2), Is.EqualTo(assignment.Get(AssignmentField.Text2)));
                Assert.That(assignment.GetText(3), Is.EqualTo(assignment.Get(AssignmentField.Text3)));
                Assert.That(assignment.GetText(4), Is.EqualTo(assignment.Get(AssignmentField.Text4)));
                Assert.That(assignment.GetText(5), Is.EqualTo(assignment.Get(AssignmentField.Text5)));
                Assert.That(assignment.GetText(6), Is.EqualTo(assignment.Get(AssignmentField.Text6)));
                Assert.That(assignment.GetText(7), Is.EqualTo(assignment.Get(AssignmentField.Text7)));
                Assert.That(assignment.GetText(8), Is.EqualTo(assignment.Get(AssignmentField.Text8)));
                Assert.That(assignment.GetText(9), Is.EqualTo(assignment.Get(AssignmentField.Text9)));
                Assert.That(assignment.GetText(10), Is.EqualTo(assignment.Get(AssignmentField.Text10)));
                Assert.That(assignment.GetText(11), Is.EqualTo(assignment.Get(AssignmentField.Text11)));
                Assert.That(assignment.GetText(12), Is.EqualTo(assignment.Get(AssignmentField.Text12)));
                Assert.That(assignment.GetText(13), Is.EqualTo(assignment.Get(AssignmentField.Text13)));
                Assert.That(assignment.GetText(14), Is.EqualTo(assignment.Get(AssignmentField.Text14)));
                Assert.That(assignment.GetText(15), Is.EqualTo(assignment.Get(AssignmentField.Text15)));
                Assert.That(assignment.GetText(16), Is.EqualTo(assignment.Get(AssignmentField.Text16)));
                Assert.That(assignment.GetText(17), Is.EqualTo(assignment.Get(AssignmentField.Text17)));
                Assert.That(assignment.GetText(18), Is.EqualTo(assignment.Get(AssignmentField.Text18)));
                Assert.That(assignment.GetText(19), Is.EqualTo(assignment.Get(AssignmentField.Text19)));
                Assert.That(assignment.GetText(20), Is.EqualTo(assignment.Get(AssignmentField.Text20)));
                Assert.That(assignment.GetText(21), Is.EqualTo(assignment.Get(AssignmentField.Text21)));
                Assert.That(assignment.GetText(22), Is.EqualTo(assignment.Get(AssignmentField.Text22)));
                Assert.That(assignment.GetText(23), Is.EqualTo(assignment.Get(AssignmentField.Text23)));
                Assert.That(assignment.GetText(24), Is.EqualTo(assignment.Get(AssignmentField.Text24)));
                Assert.That(assignment.GetText(25), Is.EqualTo(assignment.Get(AssignmentField.Text25)));
                Assert.That(assignment.GetText(26), Is.EqualTo(assignment.Get(AssignmentField.Text26)));
                Assert.That(assignment.GetText(27), Is.EqualTo(assignment.Get(AssignmentField.Text27)));
                Assert.That(assignment.GetText(28), Is.EqualTo(assignment.Get(AssignmentField.Text28)));
                Assert.That(assignment.GetText(29), Is.EqualTo(assignment.Get(AssignmentField.Text29)));
                Assert.That(assignment.GetText(20), Is.EqualTo(assignment.Get(AssignmentField.Text30)));

                Assert.That(assignment.GetStart(1), Is.EqualTo(assignment.Get(AssignmentField.Start1)));
                Assert.That(assignment.GetStart(2), Is.EqualTo(assignment.Get(AssignmentField.Start2)));
                Assert.That(assignment.GetStart(3), Is.EqualTo(assignment.Get(AssignmentField.Start3)));
                Assert.That(assignment.GetStart(4), Is.EqualTo(assignment.Get(AssignmentField.Start4)));
                Assert.That(assignment.GetStart(5), Is.EqualTo(assignment.Get(AssignmentField.Start5)));
                Assert.That(assignment.GetStart(6), Is.EqualTo(assignment.Get(AssignmentField.Start6)));
                Assert.That(assignment.GetStart(7), Is.EqualTo(assignment.Get(AssignmentField.Start7)));
                Assert.That(assignment.GetStart(8), Is.EqualTo(assignment.Get(AssignmentField.Start8)));
                Assert.That(assignment.GetStart(9), Is.EqualTo(assignment.Get(AssignmentField.Start9)));
                Assert.That(assignment.GetStart(10), Is.EqualTo(assignment.Get(AssignmentField.Start10)));

                Assert.That(assignment.GetFinish(1), Is.EqualTo(assignment.Get(AssignmentField.Finish1)));
                Assert.That(assignment.GetFinish(2), Is.EqualTo(assignment.Get(AssignmentField.Finish2)));
                Assert.That(assignment.GetFinish(3), Is.EqualTo(assignment.Get(AssignmentField.Finish3)));
                Assert.That(assignment.GetFinish(4), Is.EqualTo(assignment.Get(AssignmentField.Finish4)));
                Assert.That(assignment.GetFinish(5), Is.EqualTo(assignment.Get(AssignmentField.Finish5)));
                Assert.That(assignment.GetFinish(6), Is.EqualTo(assignment.Get(AssignmentField.Finish6)));
                Assert.That(assignment.GetFinish(7), Is.EqualTo(assignment.Get(AssignmentField.Finish7)));
                Assert.That(assignment.GetFinish(8), Is.EqualTo(assignment.Get(AssignmentField.Finish8)));
                Assert.That(assignment.GetFinish(9), Is.EqualTo(assignment.Get(AssignmentField.Finish9)));
                Assert.That(assignment.GetFinish(10), Is.EqualTo(assignment.Get(AssignmentField.Finish10)));

                Assert.That(assignment.GetNumber(1), Is.EqualTo(assignment.Get(AssignmentField.Number1)));
                Assert.That(assignment.GetNumber(2), Is.EqualTo(assignment.Get(AssignmentField.Number2)));
                Assert.That(assignment.GetNumber(3), Is.EqualTo(assignment.Get(AssignmentField.Number3)));
                Assert.That(assignment.GetNumber(4), Is.EqualTo(assignment.Get(AssignmentField.Number4)));
                Assert.That(assignment.GetNumber(5), Is.EqualTo(assignment.Get(AssignmentField.Number5)));
                Assert.That(assignment.GetNumber(6), Is.EqualTo(assignment.Get(AssignmentField.Number6)));
                Assert.That(assignment.GetNumber(7), Is.EqualTo(assignment.Get(AssignmentField.Number7)));
                Assert.That(assignment.GetNumber(8), Is.EqualTo(assignment.Get(AssignmentField.Number8)));
                Assert.That(assignment.GetNumber(9), Is.EqualTo(assignment.Get(AssignmentField.Number9)));
                Assert.That(assignment.GetNumber(10), Is.EqualTo(assignment.Get(AssignmentField.Number10)));
                Assert.That(assignment.GetNumber(11), Is.EqualTo(assignment.Get(AssignmentField.Number11)));
                Assert.That(assignment.GetNumber(12), Is.EqualTo(assignment.Get(AssignmentField.Number12)));
                Assert.That(assignment.GetNumber(13), Is.EqualTo(assignment.Get(AssignmentField.Number13)));
                Assert.That(assignment.GetNumber(14), Is.EqualTo(assignment.Get(AssignmentField.Number14)));
                Assert.That(assignment.GetNumber(15), Is.EqualTo(assignment.Get(AssignmentField.Number15)));
                Assert.That(assignment.GetNumber(16), Is.EqualTo(assignment.Get(AssignmentField.Number16)));
                Assert.That(assignment.GetNumber(17), Is.EqualTo(assignment.Get(AssignmentField.Number17)));
                Assert.That(assignment.GetNumber(18), Is.EqualTo(assignment.Get(AssignmentField.Number18)));
                Assert.That(assignment.GetNumber(19), Is.EqualTo(assignment.Get(AssignmentField.Number19)));
                Assert.That(assignment.GetNumber(20), Is.EqualTo(assignment.Get(AssignmentField.Number20)));

                Assert.That(assignment.GetDuration(1), Is.EqualTo(assignment.Get(AssignmentField.Duration1)));
                Assert.That(assignment.GetDuration(2), Is.EqualTo(assignment.Get(AssignmentField.Duration2)));
                Assert.That(assignment.GetDuration(3), Is.EqualTo(assignment.Get(AssignmentField.Duration3)));
                Assert.That(assignment.GetDuration(4), Is.EqualTo(assignment.Get(AssignmentField.Duration4)));
                Assert.That(assignment.GetDuration(5), Is.EqualTo(assignment.Get(AssignmentField.Duration5)));
                Assert.That(assignment.GetDuration(6), Is.EqualTo(assignment.Get(AssignmentField.Duration6)));
                Assert.That(assignment.GetDuration(7), Is.EqualTo(assignment.Get(AssignmentField.Duration7)));
                Assert.That(assignment.GetDuration(8), Is.EqualTo(assignment.Get(AssignmentField.Duration8)));
                Assert.That(assignment.GetDuration(9), Is.EqualTo(assignment.Get(AssignmentField.Duration9)));
                Assert.That(assignment.GetDuration(10), Is.EqualTo(assignment.Get(AssignmentField.Duration10)));

                Assert.That(assignment.GetCost(1), Is.EqualTo(assignment.Get(AssignmentField.Cost1)));
                Assert.That(assignment.GetCost(2), Is.EqualTo(assignment.Get(AssignmentField.Cost2)));
                Assert.That(assignment.GetCost(3), Is.EqualTo(assignment.Get(AssignmentField.Cost3)));
                Assert.That(assignment.GetCost(4), Is.EqualTo(assignment.Get(AssignmentField.Cost4)));
                Assert.That(assignment.GetCost(5), Is.EqualTo(assignment.Get(AssignmentField.Cost5)));
                Assert.That(assignment.GetCost(6), Is.EqualTo(assignment.Get(AssignmentField.Cost6)));
                Assert.That(assignment.GetCost(7), Is.EqualTo(assignment.Get(AssignmentField.Cost7)));
                Assert.That(assignment.GetCost(8), Is.EqualTo(assignment.Get(AssignmentField.Cost8)));
                Assert.That(assignment.GetCost(9), Is.EqualTo(assignment.Get(AssignmentField.Cost9)));
                Assert.That(assignment.GetCost(10), Is.EqualTo(assignment.Get(AssignmentField.Cost10)));

                Assert.That(assignment.GetFlag(1), Is.EqualTo(assignment.Get(AssignmentField.Flag1)));
                Assert.That(assignment.GetFlag(2), Is.EqualTo(assignment.Get(AssignmentField.Flag2)));
                Assert.That(assignment.GetFlag(3), Is.EqualTo(assignment.Get(AssignmentField.Flag3)));
                Assert.That(assignment.GetFlag(4), Is.EqualTo(assignment.Get(AssignmentField.Flag4)));
                Assert.That(assignment.GetFlag(5), Is.EqualTo(assignment.Get(AssignmentField.Flag5)));
                Assert.That(assignment.GetFlag(6), Is.EqualTo(assignment.Get(AssignmentField.Flag6)));
                Assert.That(assignment.GetFlag(7), Is.EqualTo(assignment.Get(AssignmentField.Flag7)));
                Assert.That(assignment.GetFlag(8), Is.EqualTo(assignment.Get(AssignmentField.Flag8)));
                Assert.That(assignment.GetFlag(9), Is.EqualTo(assignment.Get(AssignmentField.Flag9)));
                Assert.That(assignment.GetFlag(10), Is.EqualTo(assignment.Get(AssignmentField.Flag10)));
                Assert.That(assignment.GetFlag(11), Is.EqualTo(assignment.Get(AssignmentField.Flag11)));
                Assert.That(assignment.GetFlag(12), Is.EqualTo(assignment.Get(AssignmentField.Flag12)));
                Assert.That(assignment.GetFlag(13), Is.EqualTo(assignment.Get(AssignmentField.Flag13)));
                Assert.That(assignment.GetFlag(14), Is.EqualTo(assignment.Get(AssignmentField.Flag14)));
                Assert.That(assignment.GetFlag(15), Is.EqualTo(assignment.Get(AssignmentField.Flag15)));
                Assert.That(assignment.GetFlag(16), Is.EqualTo(assignment.Get(AssignmentField.Flag16)));
                Assert.That(assignment.GetFlag(17), Is.EqualTo(assignment.Get(AssignmentField.Flag17)));
                Assert.That(assignment.GetFlag(18), Is.EqualTo(assignment.Get(AssignmentField.Flag18)));
                Assert.That(assignment.GetFlag(19), Is.EqualTo(assignment.Get(AssignmentField.Flag19)));
                Assert.That(assignment.GetFlag(20), Is.EqualTo(assignment.Get(AssignmentField.Flag20)));

                Assert.That(assignment.LinkedFields, Is.EqualTo(assignment.Get(AssignmentField.LinkedFields)));
                //Assert.That(assignment.Overallocated, Is.EqualTo(assignment.Get(AssignmentField.Overallocated)));
                //Assert.That(assignment.TaskSummaryName, Is.EqualTo(assignment.Get(AssignmentField.TaskSummaryName)));
                Assert.That(assignment.Hyperlink, Is.EqualTo(assignment.Get(AssignmentField.Hyperlink)));
                Assert.That(assignment.HyperlinkAddress, Is.EqualTo(assignment.Get(AssignmentField.HyperlinkAddress)));
                Assert.That(assignment.HyperlinkSubAddress, Is.EqualTo(assignment.Get(AssignmentField.HyperlinkSubaddress)));
                //Assert.That(assignment.HyperlinkHref, Is.EqualTo(assignment.Get(AssignmentField.HyperlinkHref)));

                Assert.That(assignment.GetDate(1), Is.EqualTo(assignment.Get(AssignmentField.Date1)));
                Assert.That(assignment.GetDate(2), Is.EqualTo(assignment.Get(AssignmentField.Date2)));
                Assert.That(assignment.GetDate(3), Is.EqualTo(assignment.Get(AssignmentField.Date3)));
                Assert.That(assignment.GetDate(4), Is.EqualTo(assignment.Get(AssignmentField.Date4)));
                Assert.That(assignment.GetDate(5), Is.EqualTo(assignment.Get(AssignmentField.Date5)));
                Assert.That(assignment.GetDate(6), Is.EqualTo(assignment.Get(AssignmentField.Date6)));
                Assert.That(assignment.GetDate(7), Is.EqualTo(assignment.Get(AssignmentField.Date7)));
                Assert.That(assignment.GetDate(8), Is.EqualTo(assignment.Get(AssignmentField.Date8)));
                Assert.That(assignment.GetDate(9), Is.EqualTo(assignment.Get(AssignmentField.Date9)));
                Assert.That(assignment.GetDate(10), Is.EqualTo(assignment.Get(AssignmentField.Date10)));

                //Assert.That(assignment.Index, Is.EqualTo(assignment.Get(AssignmentField.Index)));
                Assert.That(assignment.CV, Is.EqualTo(assignment.Get(AssignmentField.CV)));
                Assert.That(assignment.WorkVariance, Is.EqualTo(assignment.Get(AssignmentField.WorkVariance)));
                Assert.That(assignment.StartVariance, Is.EqualTo(assignment.Get(AssignmentField.StartVariance)));
                Assert.That(assignment.FinishVariance, Is.EqualTo(assignment.Get(AssignmentField.FinishVariance)));
                Assert.That(assignment.VAC, Is.EqualTo(assignment.Get(AssignmentField.VAC)));
                //Assert.That(assignment.FixedMaterialAssignment, Is.EqualTo(assignment.Get(AssignmentField.FixedMaterialAssignment)));
                //Assert.That(assignment.ResourceType, Is.EqualTo(assignment.Get(AssignmentField.ResourceType)));
                Assert.That(assignment.HyperlinkScreenTip, Is.EqualTo(assignment.Get(AssignmentField.HyperlinkScreenTip)));
                //Assert.That(assignment.WBS, Is.EqualTo(assignment.Get(AssignmentField.Wbs)));

                Assert.That(assignment.GetBaselineWork(1), Is.EqualTo(assignment.Get(AssignmentField.Baseline1Work)));
                Assert.That(assignment.GetBaselineWork(2), Is.EqualTo(assignment.Get(AssignmentField.Baseline2Work)));
                Assert.That(assignment.GetBaselineWork(3), Is.EqualTo(assignment.Get(AssignmentField.Baseline3Work)));
                Assert.That(assignment.GetBaselineWork(4), Is.EqualTo(assignment.Get(AssignmentField.Baseline4Work)));
                Assert.That(assignment.GetBaselineWork(5), Is.EqualTo(assignment.Get(AssignmentField.Baseline5Work)));
                Assert.That(assignment.GetBaselineWork(6), Is.EqualTo(assignment.Get(AssignmentField.Baseline6Work)));
                Assert.That(assignment.GetBaselineWork(7), Is.EqualTo(assignment.Get(AssignmentField.Baseline7Work)));
                Assert.That(assignment.GetBaselineWork(8), Is.EqualTo(assignment.Get(AssignmentField.Baseline8Work)));
                Assert.That(assignment.GetBaselineWork(9), Is.EqualTo(assignment.Get(AssignmentField.Baseline9Work)));
                Assert.That(assignment.GetBaselineWork(10), Is.EqualTo(assignment.Get(AssignmentField.Baseline10Work)));

                Assert.That(assignment.GetBaselineCost(1), Is.EqualTo(assignment.Get(AssignmentField.Baseline1Cost)));
                Assert.That(assignment.GetBaselineCost(2), Is.EqualTo(assignment.Get(AssignmentField.Baseline2Cost)));
                Assert.That(assignment.GetBaselineCost(3), Is.EqualTo(assignment.Get(AssignmentField.Baseline3Cost)));
                Assert.That(assignment.GetBaselineCost(4), Is.EqualTo(assignment.Get(AssignmentField.Baseline4Cost)));
                Assert.That(assignment.GetBaselineCost(5), Is.EqualTo(assignment.Get(AssignmentField.Baseline5Cost)));
                Assert.That(assignment.GetBaselineCost(6), Is.EqualTo(assignment.Get(AssignmentField.Baseline6Cost)));
                Assert.That(assignment.GetBaselineCost(7), Is.EqualTo(assignment.Get(AssignmentField.Baseline7Cost)));
                Assert.That(assignment.GetBaselineCost(8), Is.EqualTo(assignment.Get(AssignmentField.Baseline8Cost)));
                Assert.That(assignment.GetBaselineCost(9), Is.EqualTo(assignment.Get(AssignmentField.Baseline9Cost)));
                Assert.That(assignment.GetBaselineCost(10), Is.EqualTo(assignment.Get(AssignmentField.Baseline10Cost)));

                Assert.That(assignment.GetBaselineStart(1), Is.EqualTo(assignment.Get(AssignmentField.Baseline1Start)));
                Assert.That(assignment.GetBaselineStart(2), Is.EqualTo(assignment.Get(AssignmentField.Baseline2Start)));
                Assert.That(assignment.GetBaselineStart(3), Is.EqualTo(assignment.Get(AssignmentField.Baseline3Start)));
                Assert.That(assignment.GetBaselineStart(4), Is.EqualTo(assignment.Get(AssignmentField.Baseline4Start)));
                Assert.That(assignment.GetBaselineStart(5), Is.EqualTo(assignment.Get(AssignmentField.Baseline5Start)));
                Assert.That(assignment.GetBaselineStart(6), Is.EqualTo(assignment.Get(AssignmentField.Baseline6Start)));
                Assert.That(assignment.GetBaselineStart(7), Is.EqualTo(assignment.Get(AssignmentField.Baseline7Start)));
                Assert.That(assignment.GetBaselineStart(8), Is.EqualTo(assignment.Get(AssignmentField.Baseline8Start)));
                Assert.That(assignment.GetBaselineStart(9), Is.EqualTo(assignment.Get(AssignmentField.Baseline9Start)));
                Assert.That(assignment.GetBaselineStart(10), Is.EqualTo(assignment.Get(AssignmentField.Baseline10Start)));

                Assert.That(assignment.GetBaselineFinish(1), Is.EqualTo(assignment.Get(AssignmentField.Baseline1Finish)));
                Assert.That(assignment.GetBaselineFinish(2), Is.EqualTo(assignment.Get(AssignmentField.Baseline2Finish)));
                Assert.That(assignment.GetBaselineFinish(3), Is.EqualTo(assignment.Get(AssignmentField.Baseline3Finish)));
                Assert.That(assignment.GetBaselineFinish(4), Is.EqualTo(assignment.Get(AssignmentField.Baseline4Finish)));
                Assert.That(assignment.GetBaselineFinish(5), Is.EqualTo(assignment.Get(AssignmentField.Baseline5Finish)));
                Assert.That(assignment.GetBaselineFinish(6), Is.EqualTo(assignment.Get(AssignmentField.Baseline6Finish)));
                Assert.That(assignment.GetBaselineFinish(7), Is.EqualTo(assignment.Get(AssignmentField.Baseline7Finish)));
                Assert.That(assignment.GetBaselineFinish(8), Is.EqualTo(assignment.Get(AssignmentField.Baseline8Finish)));
                Assert.That(assignment.GetBaselineFinish(9), Is.EqualTo(assignment.Get(AssignmentField.Baseline9Finish)));
                Assert.That(assignment.GetBaselineFinish(10), Is.EqualTo(assignment.Get(AssignmentField.Baseline10Finish)));

                //Assert.That(assignment.TaskOutlineNumber, Is.EqualTo(assignment.Get(AssignmentField.TaskOutlineNumber)));

                Assert.That(assignment.GetEnterpriseCost(1), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseCost1)));
                Assert.That(assignment.GetEnterpriseCost(2), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseCost2)));
                Assert.That(assignment.GetEnterpriseCost(3), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseCost3)));
                Assert.That(assignment.GetEnterpriseCost(4), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseCost4)));
                Assert.That(assignment.GetEnterpriseCost(5), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseCost5)));
                Assert.That(assignment.GetEnterpriseCost(6), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseCost6)));
                Assert.That(assignment.GetEnterpriseCost(7), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseCost7)));
                Assert.That(assignment.GetEnterpriseCost(8), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseCost8)));
                Assert.That(assignment.GetEnterpriseCost(9), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseCost9)));
                Assert.That(assignment.GetEnterpriseCost(10), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseCost10)));

                Assert.That(assignment.GetEnterpriseDate(1), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate1)));
                Assert.That(assignment.GetEnterpriseDate(2), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate2)));
                Assert.That(assignment.GetEnterpriseDate(3), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate3)));
                Assert.That(assignment.GetEnterpriseDate(4), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate4)));
                Assert.That(assignment.GetEnterpriseDate(5), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate5)));
                Assert.That(assignment.GetEnterpriseDate(6), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate6)));
                Assert.That(assignment.GetEnterpriseDate(7), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate7)));
                Assert.That(assignment.GetEnterpriseDate(8), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate8)));
                Assert.That(assignment.GetEnterpriseDate(9), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate9)));
                Assert.That(assignment.GetEnterpriseDate(10), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate10)));
                Assert.That(assignment.GetEnterpriseDate(11), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate11)));
                Assert.That(assignment.GetEnterpriseDate(12), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate12)));
                Assert.That(assignment.GetEnterpriseDate(13), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate13)));
                Assert.That(assignment.GetEnterpriseDate(14), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate14)));
                Assert.That(assignment.GetEnterpriseDate(15), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate15)));
                Assert.That(assignment.GetEnterpriseDate(16), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate16)));
                Assert.That(assignment.GetEnterpriseDate(17), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate17)));
                Assert.That(assignment.GetEnterpriseDate(18), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate18)));
                Assert.That(assignment.GetEnterpriseDate(19), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate19)));
                Assert.That(assignment.GetEnterpriseDate(20), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate20)));
                Assert.That(assignment.GetEnterpriseDate(21), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate21)));
                Assert.That(assignment.GetEnterpriseDate(22), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate22)));
                Assert.That(assignment.GetEnterpriseDate(23), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate23)));
                Assert.That(assignment.GetEnterpriseDate(24), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate24)));
                Assert.That(assignment.GetEnterpriseDate(25), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate25)));
                Assert.That(assignment.GetEnterpriseDate(26), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate26)));
                Assert.That(assignment.GetEnterpriseDate(27), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate27)));
                Assert.That(assignment.GetEnterpriseDate(28), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate28)));
                Assert.That(assignment.GetEnterpriseDate(29), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate29)));
                Assert.That(assignment.GetEnterpriseDate(30), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDate30)));

                Assert.That(assignment.GetEnterpriseDuration(1), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDuration1)));
                Assert.That(assignment.GetEnterpriseDuration(2), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDuration2)));
                Assert.That(assignment.GetEnterpriseDuration(3), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDuration3)));
                Assert.That(assignment.GetEnterpriseDuration(4), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDuration4)));
                Assert.That(assignment.GetEnterpriseDuration(5), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDuration5)));
                Assert.That(assignment.GetEnterpriseDuration(6), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDuration6)));
                Assert.That(assignment.GetEnterpriseDuration(7), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDuration7)));
                Assert.That(assignment.GetEnterpriseDuration(8), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDuration8)));
                Assert.That(assignment.GetEnterpriseDuration(9), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDuration9)));
                Assert.That(assignment.GetEnterpriseDuration(10), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseDuration10)));

                Assert.That(assignment.GetEnterpriseFlag(1), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(2), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(3), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(4), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(5), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(6), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(7), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(8), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(9), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(10), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(11), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(12), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(13), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(14), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(15), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(16), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(17), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(18), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(19), Is.False);
                Assert.That(assignment.GetEnterpriseFlag(20), Is.False);

                Assert.That(assignment.GetEnterpriseNumber(1), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber1)));
                Assert.That(assignment.GetEnterpriseNumber(2), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber2)));
                Assert.That(assignment.GetEnterpriseNumber(3), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber3)));
                Assert.That(assignment.GetEnterpriseNumber(4), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber4)));
                Assert.That(assignment.GetEnterpriseNumber(5), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber5)));
                Assert.That(assignment.GetEnterpriseNumber(6), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber6)));
                Assert.That(assignment.GetEnterpriseNumber(7), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber7)));
                Assert.That(assignment.GetEnterpriseNumber(8), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber8)));
                Assert.That(assignment.GetEnterpriseNumber(9), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber9)));
                Assert.That(assignment.GetEnterpriseNumber(10), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber10)));
                Assert.That(assignment.GetEnterpriseNumber(11), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber11)));
                Assert.That(assignment.GetEnterpriseNumber(12), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber12)));
                Assert.That(assignment.GetEnterpriseNumber(13), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber13)));
                Assert.That(assignment.GetEnterpriseNumber(14), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber14)));
                Assert.That(assignment.GetEnterpriseNumber(15), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber15)));
                Assert.That(assignment.GetEnterpriseNumber(16), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber16)));
                Assert.That(assignment.GetEnterpriseNumber(17), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber17)));
                Assert.That(assignment.GetEnterpriseNumber(18), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber18)));
                Assert.That(assignment.GetEnterpriseNumber(19), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber19)));
                Assert.That(assignment.GetEnterpriseNumber(20), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber20)));
                Assert.That(assignment.GetEnterpriseNumber(21), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber21)));
                Assert.That(assignment.GetEnterpriseNumber(22), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber22)));
                Assert.That(assignment.GetEnterpriseNumber(23), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber23)));
                Assert.That(assignment.GetEnterpriseNumber(24), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber24)));
                Assert.That(assignment.GetEnterpriseNumber(25), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber25)));
                Assert.That(assignment.GetEnterpriseNumber(26), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber26)));
                Assert.That(assignment.GetEnterpriseNumber(27), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber27)));
                Assert.That(assignment.GetEnterpriseNumber(28), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber28)));
                Assert.That(assignment.GetEnterpriseNumber(29), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber29)));
                Assert.That(assignment.GetEnterpriseNumber(30), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber30)));
                Assert.That(assignment.GetEnterpriseNumber(31), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber31)));
                Assert.That(assignment.GetEnterpriseNumber(32), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber32)));
                Assert.That(assignment.GetEnterpriseNumber(33), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber33)));
                Assert.That(assignment.GetEnterpriseNumber(34), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber34)));
                Assert.That(assignment.GetEnterpriseNumber(35), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber35)));
                Assert.That(assignment.GetEnterpriseNumber(36), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber36)));
                Assert.That(assignment.GetEnterpriseNumber(37), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber37)));
                Assert.That(assignment.GetEnterpriseNumber(38), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber38)));
                Assert.That(assignment.GetEnterpriseNumber(39), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber39)));
                Assert.That(assignment.GetEnterpriseNumber(40), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseNumber40)));

                Assert.That(assignment.GetEnterpriseText(1), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText1)));
                Assert.That(assignment.GetEnterpriseText(2), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText2)));
                Assert.That(assignment.GetEnterpriseText(3), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText3)));
                Assert.That(assignment.GetEnterpriseText(4), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText4)));
                Assert.That(assignment.GetEnterpriseText(5), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText5)));
                Assert.That(assignment.GetEnterpriseText(6), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText6)));
                Assert.That(assignment.GetEnterpriseText(7), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText7)));
                Assert.That(assignment.GetEnterpriseText(8), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText8)));
                Assert.That(assignment.GetEnterpriseText(9), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText9)));
                Assert.That(assignment.GetEnterpriseText(10), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText10)));
                Assert.That(assignment.GetEnterpriseText(11), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText11)));
                Assert.That(assignment.GetEnterpriseText(12), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText12)));
                Assert.That(assignment.GetEnterpriseText(13), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText13)));
                Assert.That(assignment.GetEnterpriseText(14), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText14)));
                Assert.That(assignment.GetEnterpriseText(15), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText15)));
                Assert.That(assignment.GetEnterpriseText(16), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText16)));
                Assert.That(assignment.GetEnterpriseText(17), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText17)));
                Assert.That(assignment.GetEnterpriseText(18), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText18)));
                Assert.That(assignment.GetEnterpriseText(19), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText19)));
                Assert.That(assignment.GetEnterpriseText(20), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText20)));
                Assert.That(assignment.GetEnterpriseText(21), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText21)));
                Assert.That(assignment.GetEnterpriseText(22), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText22)));
                Assert.That(assignment.GetEnterpriseText(23), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText23)));
                Assert.That(assignment.GetEnterpriseText(24), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText24)));
                Assert.That(assignment.GetEnterpriseText(25), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText25)));
                Assert.That(assignment.GetEnterpriseText(26), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText26)));
                Assert.That(assignment.GetEnterpriseText(27), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText27)));
                Assert.That(assignment.GetEnterpriseText(28), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText28)));
                Assert.That(assignment.GetEnterpriseText(29), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText29)));
                Assert.That(assignment.GetEnterpriseText(30), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText30)));
                Assert.That(assignment.GetEnterpriseText(31), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText31)));
                Assert.That(assignment.GetEnterpriseText(32), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText32)));
                Assert.That(assignment.GetEnterpriseText(33), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText33)));
                Assert.That(assignment.GetEnterpriseText(34), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText34)));
                Assert.That(assignment.GetEnterpriseText(35), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText35)));
                Assert.That(assignment.GetEnterpriseText(36), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText36)));
                Assert.That(assignment.GetEnterpriseText(37), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText37)));
                Assert.That(assignment.GetEnterpriseText(38), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText38)));
                Assert.That(assignment.GetEnterpriseText(39), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText39)));
                Assert.That(assignment.GetEnterpriseText(40), Is.EqualTo(assignment.Get(AssignmentField.EnterpriseText40)));


                //Assert.That(assignment.EnterpriseResourceOutlineCode1, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode1)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode2, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode2)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode3, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode3)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode4, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode4)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode5, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode5)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode6, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode6)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode7, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode7)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode8, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode8)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode9, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode9)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode10, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode10)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode11, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode11)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode12, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode12)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode13, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode13)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode14, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode14)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode15, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode15)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode16, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode16)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode17, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode17)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode18, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode18)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode19, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode19)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode20, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode20)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode21, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode21)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode22, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode22)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode23, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode23)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode24, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode24)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode25, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode25)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode26, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode26)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode27, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode27)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode28, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode28)));
                //Assert.That(assignment.EnterpriseResourceOutlineCode29, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceOutlineCode29)));
                //Assert.That(assignment.EnterpriseResourceRbs, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceRbs)));
                Assert.That(assignment.ResourceRequestType, Is.EqualTo(assignment.Get(AssignmentField.ResourceRequestType)));
                //Assert.That(assignment.EnterpriseTeamMember, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseTeamMember)));
                //Assert.That(assignment.EnterpriseResourceMultiValue20, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceMultiValue20)));
                //Assert.That(assignment.EnterpriseResourceMultiValue21, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceMultiValue21)));
                //Assert.That(assignment.EnterpriseResourceMultiValue22, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceMultiValue22)));
                //Assert.That(assignment.EnterpriseResourceMultiValue23, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceMultiValue23)));
                //Assert.That(assignment.EnterpriseResourceMultiValue24, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceMultiValue24)));
                //Assert.That(assignment.EnterpriseResourceMultiValue25, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceMultiValue25)));
                //Assert.That(assignment.EnterpriseResourceMultiValue26, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceMultiValue26)));
                //Assert.That(assignment.EnterpriseResourceMultiValue27, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceMultiValue27)));
                //Assert.That(assignment.EnterpriseResourceMultiValue28, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceMultiValue28)));
                //Assert.That(assignment.EnterpriseResourceMultiValue29, Is.EqualTo(assignment.Get(AssignmentField.EnterpriseResourceMultiValue29)));
                //Assert.That(assignment.ActualWorkProtected, Is.EqualTo(assignment.Get(AssignmentField.ActualWorkProtected)));
                //Assert.That(assignment.ActualOvertimeWorkProtected, Is.EqualTo(assignment.Get(AssignmentField.ActualOvertimeWorkProtected)));
                Assert.That(assignment.CreateDate, Is.EqualTo(assignment.Get(AssignmentField.Created)));
                Assert.That(assignment.GUID, Is.EqualTo(assignment.Get(AssignmentField.GUID)));
                //Assert.That(assignment.AssignmentTaskGuid, Is.EqualTo(assignment.Get(AssignmentField.AssignmentTaskGuid)));
                //Assert.That(assignment.AssignmentResourceGuid, Is.EqualTo(assignment.Get(AssignmentField.AssignmentResourceGuid)));
                //Assert.That(assignment.Summary, Is.EqualTo(assignment.Get(AssignmentField.Summary)));
                //Assert.That(assignment.Owner, Is.EqualTo(assignment.Get(AssignmentField.Owner)));
                Assert.That(assignment.BudgetWork, Is.EqualTo(assignment.Get(AssignmentField.BudgetWork)));
                Assert.That(assignment.BudgetCost, Is.EqualTo(assignment.Get(AssignmentField.BudgetCost)));
                Assert.That(assignment.BaselineBudgetWork, Is.EqualTo(assignment.Get(AssignmentField.BaselineBudgetWork)));
                Assert.That(assignment.BaselineBudgetCost, Is.EqualTo(assignment.Get(AssignmentField.BaselineBudgetCost)));

                Assert.That(assignment.GetBaselineBudgetWork(1), Is.EqualTo(assignment.Get(AssignmentField.Baseline1BudgetWork)));
                Assert.That(assignment.GetBaselineBudgetWork(2), Is.EqualTo(assignment.Get(AssignmentField.Baseline2BudgetWork)));
                Assert.That(assignment.GetBaselineBudgetWork(3), Is.EqualTo(assignment.Get(AssignmentField.Baseline3BudgetWork)));
                Assert.That(assignment.GetBaselineBudgetWork(4), Is.EqualTo(assignment.Get(AssignmentField.Baseline4BudgetWork)));
                Assert.That(assignment.GetBaselineBudgetWork(5), Is.EqualTo(assignment.Get(AssignmentField.Baseline5BudgetWork)));
                Assert.That(assignment.GetBaselineBudgetWork(6), Is.EqualTo(assignment.Get(AssignmentField.Baseline6BudgetWork)));
                Assert.That(assignment.GetBaselineBudgetWork(7), Is.EqualTo(assignment.Get(AssignmentField.Baseline7BudgetWork)));
                Assert.That(assignment.GetBaselineBudgetWork(8), Is.EqualTo(assignment.Get(AssignmentField.Baseline8BudgetWork)));
                Assert.That(assignment.GetBaselineBudgetWork(9), Is.EqualTo(assignment.Get(AssignmentField.Baseline9BudgetWork)));
                Assert.That(assignment.GetBaselineBudgetWork(10), Is.EqualTo(assignment.Get(AssignmentField.Baseline10BudgetWork)));

                Assert.That(assignment.GetBaselineBudgetCost(1), Is.EqualTo(assignment.Get(AssignmentField.Baseline1BudgetCost)));
                Assert.That(assignment.GetBaselineBudgetCost(2), Is.EqualTo(assignment.Get(AssignmentField.Baseline2BudgetCost)));
                Assert.That(assignment.GetBaselineBudgetCost(3), Is.EqualTo(assignment.Get(AssignmentField.Baseline3BudgetCost)));
                Assert.That(assignment.GetBaselineBudgetCost(4), Is.EqualTo(assignment.Get(AssignmentField.Baseline4BudgetCost)));
                Assert.That(assignment.GetBaselineBudgetCost(5), Is.EqualTo(assignment.Get(AssignmentField.Baseline5BudgetCost)));
                Assert.That(assignment.GetBaselineBudgetCost(6), Is.EqualTo(assignment.Get(AssignmentField.Baseline6BudgetCost)));
                Assert.That(assignment.GetBaselineBudgetCost(7), Is.EqualTo(assignment.Get(AssignmentField.Baseline7BudgetCost)));
                Assert.That(assignment.GetBaselineBudgetCost(8), Is.EqualTo(assignment.Get(AssignmentField.Baseline8BudgetCost)));
                Assert.That(assignment.GetBaselineBudgetCost(9), Is.EqualTo(assignment.Get(AssignmentField.Baseline9BudgetCost)));
                Assert.That(assignment.GetBaselineBudgetCost(10), Is.EqualTo(assignment.Get(AssignmentField.Baseline10BudgetCost)));

                //Assert.That(assignment.Unavailable, Is.EqualTo(assignment.Get(AssignmentField.Unavailable)));
                //Assert.That(assignment.HyperlinkData, Is.EqualTo(assignment.Get(AssignmentField.HyperlinkData)));
                Assert.That(assignment.Resume, Is.EqualTo(assignment.Get(AssignmentField.Resume)));
                Assert.That(assignment.Stop, Is.EqualTo(assignment.Get(AssignmentField.Stop)));
                Assert.That(assignment.PlannedWork, Is.EqualTo(assignment.Get(AssignmentField.PlannedWork)));
                Assert.That(assignment.PlannedCost, Is.EqualTo(assignment.Get(AssignmentField.PlannedCost)));
                Assert.That(assignment.PlannedStart, Is.EqualTo(assignment.Get(AssignmentField.PlannedStart)));
                Assert.That(assignment.PlannedFinish, Is.EqualTo(assignment.Get(AssignmentField.PlannedFinish)));
                Assert.That(assignment.RateIndex, Is.EqualTo(assignment.Get(AssignmentField.RateIndex)));
                Assert.That(assignment.RoleUniqueID, Is.EqualTo(assignment.Get(AssignmentField.RoleUniqueId)));
                Assert.That(assignment.OverrideRate, Is.EqualTo(assignment.Get(AssignmentField.OverrideRate)));
                Assert.That(assignment.RateSource, Is.EqualTo(assignment.Get(AssignmentField.RateSource)));
                Assert.That(assignment.CalculateCostsFromUnits, Is.EqualTo(assignment.Get(AssignmentField.CalculateCostsFromUnits)));
                Assert.That(assignment.CostAccountUniqueID, Is.EqualTo(assignment.Get(AssignmentField.CostAccountUniqueId)));
                Assert.That(assignment.Finish, Is.EqualTo(assignment.Get(AssignmentField.Finish)));
            });
        }

        [Test]
        public void SetterTests()
        {
            var project = new ProjectFile();
            var task = project.AddTask();
            var resource = project.AddResource();
            var assignment = task.AddResourceAssignment(resource);

            assignment.CalculateCostsFromUnits = true;
            assignment.Confirmed = true;
            assignment.LinkedFields = true;
            assignment.ResponsePending = true;
            assignment.TeamStatusPending = true;
            assignment.UpdateNeeded = true;

            assignment.ActualFinish = DateTime.Now;
            assignment.ActualStart = DateTime.Now;
            assignment.BaselineFinish = DateTime.Now;
            assignment.BaselineStart = DateTime.Now;
            assignment.CreateDate = DateTime.Now;
            assignment.Finish = DateTime.Now;
            assignment.PlannedFinish = DateTime.Now;
            assignment.PlannedStart = DateTime.Now;
            assignment.Resume = DateTime.Now;
            assignment.Start = DateTime.Now;
            assignment.Stop = DateTime.Now;

            assignment.ActualCost = 1.0;
            assignment.ActualOvertimeCost = 1.0;
            assignment.ACWP = 1.0;
            assignment.BaselineBudgetCost = 1.0;
            assignment.BaselineCost = 1.0;
            assignment.BCWP = 1.0;
            assignment.BCWS = 1.0;
            assignment.BudgetCost = 1.0;
            assignment.Cost = 1.0;
            assignment.CostVariance = 1.0;
            assignment.CV = 1.0;
            assignment.OvertimeCost = 1.0;
            assignment.PercentageWorkComplete = 1.0;
            assignment.PlannedCost = 1.0;
            assignment.RemainingCost = 1.0;
            assignment.RemainingOvertimeCost = 1.0;
            assignment.SV = 1.0;
            assignment.Units = 1.0;
            assignment.VAC = 1.0;

            assignment.ActualOvertimeWork = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.ActualWork = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.BaselineBudgetWork = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.BaselineWork = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.BudgetWork = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.Delay = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.FinishVariance = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.LevelingDelay = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.OvertimeWork = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.PlannedWork = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.RegularWork = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.RemainingOvertimeWork = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.RemainingWork = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.StartVariance = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.Work = Duration.GetInstance(1.0, TimeUnit.Days);
            assignment.WorkVariance = Duration.GetInstance(1.0, TimeUnit.Days);

            assignment.GUID = Guid.NewGuid();

            assignment.CostRateTableIndex = 1;
            assignment.CostAccountUniqueID = 1;
            assignment.RateIndex = 1;
            assignment.ResourceUniqueID = 1;
            assignment.RoleUniqueID = 1;
            assignment.TaskUniqueID = 1;
            assignment.UniqueID = 1;

            assignment.OverrideRate = new Rate(1, TimeUnit.Hours);

            assignment.RateSource = RateSource.Resource;

            assignment.ResourceRequestType = ResourceRequestType.None;

            assignment.Hyperlink = "foo";
            assignment.HyperlinkAddress = "foo";
            assignment.HyperlinkScreenTip = "foo";
            assignment.HyperlinkSubAddress = "foo";
            assignment.Notes = "foo";

            assignment.VariableRateUnits = TimeUnit.Hours;

            assignment.WorkContour = WorkContour.Flat;
        }
    }
}
