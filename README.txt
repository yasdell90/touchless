# Touch Less Coding Assignment

Welcome to the TouchLess Coding Assignment! We can't wait to see what you come up with!

**Please read through this entire file before starting the test.**

Criteria: At Touch Less, We provide cutting edge IOT solutions. For this Asessment, We are expecting you to produce a solution for the simple question mentioned below.

There is a shopping mall with 8 vehicle gates (8 entrance and 8 exit) . At each gate there is a Touchless hardware (PC) that reads the plate numbers of the vehicles and open the gate barrier for the visitors.
All of the hardware are far away from each other and require wifi connection to connect to the cloud server.

When a automobile enters (test and an image) at one of the entrances, it must go to the cloud and then the cloud must inform all of the exit hardware units.

## Inputs

* `Plate number` - A string of Alpha Numerics. 
* `Entrance Timestamp` - A Unix timestamp.
* `INOUTAgentMACID` - A string of integers.
* `OUTAgentMACID` - A string of Integers.


## Output

Your ASP demo App should focus on loading these inputs, processing them according to the above mentioned **criteria** 

The output should be API which focusses around each Platenumber. For each Plate number, we want to know the answers for the following questions.

1. Activity Log JSON. [Mentioned below]
2. Session Log JSON. [Mentioned below]
3. Analytics.JSON. [Mentioned below]



The format of the JSON output file should be similar to this structure:

```
<%-- Activity.json --%>
{
	"102123": {
		"Type": "IN",
		"OUTAgentMACID": "00-14-22-01-23-45",
		"PlateNumber": {
			"Image": "/poll/data/date0/img.png",
			"Number": "ABC1234",
			"TimeStamp": 5901291
		}
	},
	"102124": {
		"Type": "OUT",
		"OUTAgentMACID": "00-14-22-01-31-45",
		"PlateNumber": {
			"Image": "/poll/data/date0/img1.png",
			"Number": "ABC1234",
			"TimeStamp": 5991291
		}
	},
	"102125": {
		"Type": "IN",
		"INAgentMACID": "00-14-22-01-63-45",
		"PlateNumber": {
			"Image": "/poll/data/date1/img2.png",
			"Number": "ABC1234",
			"TimeStamp": 6001239
		}
	}
}

In the above Json the auto inceremented value 102123 is the sessionID

<%-- Session.json --%>
{
	{
	"SessionID":102123,
	"Platenumber":"ABCD1234",
	"Intime":53808092,
	"Outtime": NA,
	"INAgentMACID":"00-24-22-01-23-45",
	"OUTAgentMACID":"00-64-22-01-23-45",
	"Status": "ongoing"	
	},
	{
	"SessionID":102222,
	"Platenumber":"ABFD1234",
	"Intime":53808032,
	"Outtime": 53808032,
	"INAgentMACID":"00-24-32-01-23-45",
	"OUTAgentMACID":"00-64-27-01-23-45",
	"Status": "Ended"	
	}
}

<%-- Analytics.json --%>

{
	"Date":"DDMMYYY",
	"TotalSessions":"209",
	"OngoingSessions":"59",
	"FinishedSessions":"150"
}

```

## Implementation

We mostly use C# at Touch Less. So we recommend you to write your code in C#.

You should write your code as if it's going straight to Production, so it needs to be production ready, and maintainable for other developers. To that end, heres what we care about when we write code, and we want you to care about these things too, so we expect the following to be demonstrated in your code base:

* **Domain Modeling** - Your solution should model the domain it's working within for clarity.
* **Design Patterns** - Don't reinvent the wheel. If you know a pattern which suits, use it.
* **Automated Tests** - Your code should be fully tested. See below under **Testing**
* **Logging** - Your code should include logs, logging to `STDOUT`. Logging is essential in debugging a system running in production. Logs at the `INFO` level should include decisions your program is making, while the `DEBUG` level can be anything that adds more context to the decision.
* **Metrics** - We care about how the system is operating, and our metrics are used to report on important business-level events. We'd like you to think about what metrics you should track in your solution, and at minimum create comments in your code around what metric you'd increment/decrement at that point.
* **Performant** - You don't need to optimise to the millisecond level, but don't do things which will obviously cause performance issues in production.
* **Failure Handling** - You should expect things to go wrong, and assumptions to be wrong. Your code should handle these situations.
* **Git Commits** - This repo is a git repo. You should have small, frequent, focussed and atomic commits to the codebase which illustrates your progression through the problem.

## Testing

At Touch Less, we believe tests are better than documentation. Your tests are what describes your solution, so Unit and Integration tests are a must. We've even given you a `test` path for you to put your tests inside. We want you to test the happy path, edge cases and failure scenarios. If your test framework uses a different path, feel free to rename the one we've provided.

Additionally, you should include a System test to verify your solution in its entirety. We've provided a test fixture at `test/fixture/expected_output.json` for you to write a test around, which you should use.

## Rules

There following requirements need to be meet:

- Generate a random `Activity.json` with 100 entries and produce the `session.json` and `Analytics.json` 
- Plan and design a simple architecture.
- Make sure that you receive acknowledgement for data transfer among agents and servers with agents having dynamic IP address? 
- Ensure real-time data transfer happening between agents and server maintaining data sync?
- Mention the details about your solition for the scalabiltiy of the above criteria with 1000 devices in the `submissions.md`

## Submission

Your submission must run on Windows. 

The code you write for the solution should be in the `src` folder, and your tests should be in the `test` folder (or similar if your framework uses something different). Unit, integration and system tests should be in separate folders within there.

Your solution should update the `bin/run` script to install all dependencies and execute your application. It should provide the result JSON file into the `output` folder of the project.

Similarly, your solution should update the `bin/test` script to install all dependencies and run your automated tests.

Take some time to describe your submission's approach, and any platform requirements, which cannot be automatically installed via the `bin/` scripts. Put this into a `SUBMISSION.md` file in the root of your project. 

When you're ready, please zip the entire project folder, including the `.git` folder and submit it via email to `info@touchless.asia`. Please ensure the zip file is your name so we know who it belongs to!

**Best of luck**

The Touch Less Engineering Team
