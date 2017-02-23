﻿using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HueLib2;
using Action = HueLib2.Action;
using System.Collections.Generic;

namespace HueLib2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //string data =
            //       "{\"name\": \"presence1\",\"conditions\": [{\"address\": \"/sensors/3/state/presence\",\"operator\": \"eq\",\"value\": \"true\"}],\"actions\": [{\"address\": \"/lights/1/state\",\"method\": \"PUT\",\"body\": {\"on\": true}}],\"owner\": \"bGSunyXwInVnikD8MrZbGL3ltn9uUWUy7e6ELimp\",\"timestriggered\": 0,\"lasttriggered\": \"none\",\"created\": \"2017-01-05T16:42:06\",\"status\": \"enabled\"}";
            //     Rule test = Serializer.DeserializeToObject<Rule>(data);
            //    
            //ScheduleCreatorViewModel sv = new ScheduleCreatorViewModel();
            // string test = Serializer.SerializeToJson(new WebException());
            Rule newrule = new Rule();
            newrule.name = "test";
            newrule.actions = new List<RuleAction>();
            newrule.actions.Add(new RuleAction() { address = "/sensor/2/state", method = "PUT", body = new ClipGenericStatusState { status = 1 } });
            newrule.actions.Add(new RuleAction() { address = "/sensor/4/state", method = "PUT", body = new ClipGenericStatusState { status = 2 } });
            string json = Serializer.SerializeToJson(newrule);

            Rule Test = Serializer.DeserializeToObject<Rule>(json);

        }
    }
}
