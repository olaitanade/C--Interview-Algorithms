using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class TopologicalSort
    {
		public static List<int> TopologicalSortSolution1(List<int> jobs, List<int[]> deps)
		{
			JobGraph jobGraph = createJobGraph(jobs, deps);
			return getOrderedJobs(jobGraph);
		}

		public static JobGraph createJobGraph(List<int> jobs, List<int[]> deps)
		{
			JobGraph graph = new JobGraph(jobs);
			foreach (int[] dep in deps)
			{
				graph.addPrereq(dep[1], dep[0]);
			}
			return graph;
		}

		public static List<int> getOrderedJobs(JobGraph graph)
		{
			List<int> orderedJobs = new List<int>();
			List<JobNode> nodes = new List<JobNode>(graph.nodes);
			while (nodes.Count > 0)
			{
				JobNode node = nodes[nodes.Count - 1];
				nodes.RemoveAt(nodes.Count - 1);
				bool ContainsCycle = depthFirstTraverse(node, orderedJobs);
				if (ContainsCycle) return new List<int>();
			}
			return orderedJobs;
		}

		public static bool depthFirstTraverse(JobNode node, List<int> orderedJobs)
		{
			if (node.visited) return false;
			if (node.visiting) return true;
			node.visiting = true;
			foreach (JobNode prereqNode in node.prereqs)
			{
				bool ContainsCycle = depthFirstTraverse(prereqNode, orderedJobs);
				if (ContainsCycle) return true;
			}
			node.visited = true;
			node.visiting = false;
			orderedJobs.Add(node.job);
			return false;
		}

		public class JobGraph
		{
			public List<JobNode> nodes;
			public Dictionary<int, JobNode> graph;

			public JobGraph(List<int> jobs)
			{
				nodes = new List<JobNode>();
				graph = new Dictionary<int, JobNode>();
				foreach (int job in jobs)
				{
					addNode(job);
				}
			}

			public void addPrereq(int job, int prereq)
			{
				JobNode jobNode = getNode(job);
				JobNode prereqNode = getNode(prereq);
				jobNode.prereqs.Add(prereqNode);
			}

			public void addNode(int job)
			{
				graph.Add(job, new JobNode(job));
				nodes.Add(graph[job]);
			}

			public JobNode getNode(int job)
			{
				if (!graph.ContainsKey(job)) addNode(job);
				return graph[job];
			}
		}

		public class JobNode
		{
			public int job;
			public List<JobNode> prereqs;
			public bool visited;
			public bool visiting;

			public JobNode(int job)
			{
				this.job = job;
				prereqs = new List<JobNode>();
				visited = false;
				visiting = false;
			}
		}
	}
}