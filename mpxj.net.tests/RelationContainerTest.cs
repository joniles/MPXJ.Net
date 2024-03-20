﻿using NUnit.Framework;
using org.mpxj.reader;

namespace org.mpxj
{
    public class RelationContainerTest
    {
        [Test]
        public void MethodTest()
        {
            var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
            Assert.That(project, Is.Not.Null);

            Assert.That(project.Relations, Has.Count.EqualTo(6));

            var relation = project.Relations[0];
            Assert.Multiple(() =>
            {
                Assert.That(relation.SourceTask.UniqueID, Is.EqualTo(4));
                Assert.That(relation.TargetTask.UniqueID, Is.EqualTo(3));
                Assert.That(relation.Type, Is.EqualTo(RelationType.FinishStart));
                Assert.That(relation.Lag, Is.EqualTo(Duration.GetInstance(project, 1, TimeUnit.Days)));
                Assert.That(relation.UniqueID, Is.EqualTo(1));
            });
        }
    }
}