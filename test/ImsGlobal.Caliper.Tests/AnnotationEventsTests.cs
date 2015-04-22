﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using Xunit;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Entities.Agent;
	using ImsGlobal.Caliper.Entities.Annotation;
	using ImsGlobal.Caliper.Events.Annotation;

	public class AnnotationEventsTests {

		[Fact]
		public void BookmarkAnnotationEvent_MatchesReferenceJson() {

			var bookmarkAnnotation = new BookmarkAnnotation( "https://someEduApp.edu/bookmarks/00001" ) {
				Annotated = TestEntities.EpubSubChap432,
				BookmarkNotes = "The Intolerable Acts (1774)--bad idea Lord North",
				DateCreated = TestEntities.DefaultDateCreated,
				DateModified = TestEntities.DefaultDateModified
			};

			var bookmarkEvent = new AnnotationEvent( bookmarkAnnotation ) {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.EpubSubChap432_Frame,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			var eventJson = JObject.FromObject( bookmarkEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperBookmarkAnnotationEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

		[Fact]
		public void HighlightAnnotationEvent_MatchesReferenceJson() {

			var highlightAnnotation = new HighlightAnnotation( "https://someEduApp.edu/highlights/12345" ) {
				Annotated = TestEntities.EpubSubChap431,
				Selection = new TextPositionSelector { Start = "455", End = "489" },
				SelectionText = "Life, Liberty and the pursuit of Happiness",
				DateCreated = TestEntities.DefaultDateCreated,
				DateModified = TestEntities.DefaultDateModified
			};

			var bookmarkEvent = new AnnotationEvent( highlightAnnotation ) {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.EpubSubChap431_Frame,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			var eventJson = JObject.FromObject( bookmarkEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperHighlightAnnotationEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

		[Fact]
		public void ShareAnnotationEvent_MatchesReferenceJson() {

			var shareAnnotation = new ShareAnnotation( "https://someEduApp.edu/shared/9999" ) {
				Annotated = TestEntities.EpubSubChap433,
				WithAgents = new [] {
					new Person( "https://some-university.edu/students/657585" ) {
						DateCreated = TestEntities.DefaultDateCreated,
						DateModified = TestEntities.DefaultDateModified
					},
					new Person( "https://some-university.edu/students/667788" ) {
						DateCreated = TestEntities.DefaultDateCreated,
						DateModified = TestEntities.DefaultDateModified
					}
				},
				DateCreated = TestEntities.DefaultDateCreated,
				DateModified = TestEntities.DefaultDateModified
			};

			var bookmarkEvent = new AnnotationEvent( shareAnnotation ) {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.EpubSubChap433_Frame,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			var eventJson = JObject.FromObject( bookmarkEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperSharedAnnotationEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

		[Fact]
		public void TagAnnotationEvent_MatchesReferenceJson() {

			var tagAnnotation = new TagAnnotation( "https://someEduApp.edu/tags/7654" ) {
				Annotated = TestEntities.EpubSubChap434,
				Tags = new [] { "to-read", "1765", "shared-with-project-team" },
				DateCreated = TestEntities.DefaultDateCreated,
				DateModified = TestEntities.DefaultDateModified
			};

			var tagEvent = new AnnotationEvent( tagAnnotation ) {
				EdApp = TestEntities.Readium,
				Group = TestEntities.AmRev101_Group001,
				Actor = TestEntities.Student554433,
				Object = TestEntities.EpubSubChap434_Frame,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			var eventJson = JObject.FromObject( tagEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperTagAnnotationEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

	}

}
