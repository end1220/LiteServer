﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SuperSocket;
using SuperSocket.Common;
using SuperSocket.SocketBase;
using SuperSocket.SocketEngine;
using SuperSocket.SocketBase.Protocol;


namespace LiteServer
{
	class Program
	{
		static void appServer_NewSessionConnected(AppSession session)
		{
			session.Send("Welcome to SuperSocket Telnet Server");
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Press any key to start the server!");

			Console.ReadKey();
			Console.WriteLine();

			var appServer = new AppServer();

			appServer.NewSessionConnected += new SessionHandler<AppSession>(appServer_NewSessionConnected);
			appServer.NewRequestReceived += new RequestHandler<AppSession, StringRequestInfo>(appServer_NewRequestReceived);

			//Setup the appServer
			if (!appServer.Setup(2012)) //Setup with listening port
			{
				Console.WriteLine("Failed to setup!");
				Console.ReadKey();
				return;
			}

			Console.WriteLine();

			//Try to start the appServer
			if (!appServer.Start())
			{
				Console.WriteLine("Failed to start!");
				Console.ReadKey();
				return;
			}

			Console.WriteLine("The server started successfully, press key 'q' to stop it!");

			while (Console.ReadKey().KeyChar != 'q')
			{
				Console.WriteLine();
				continue;
			}

			//Stop the appServer
			appServer.Stop();

			Console.WriteLine("The server was stopped!");
			Console.ReadKey();
		}


		static void appServer_NewRequestReceived(AppSession session, StringRequestInfo requestInfo)
		{
			switch (requestInfo.Key.ToUpper())
			{
				case ("ECHO"):
					session.Send(requestInfo.Body);
					break;

				case ("ADD"):
					session.Send(requestInfo.Parameters.Select(p => Convert.ToInt32(p)).Sum().ToString());
					break;

				case ("MULT"):

					var result = 1;

					foreach (var factor in requestInfo.Parameters.Select(p => Convert.ToInt32(p)))
					{
						result *= factor;
					}

					session.Send(result.ToString());
					break;
			}
		}


	}
}
