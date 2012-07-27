﻿//-------------------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs" company="Appccelerate">
//   Copyright (c) 2008-2012
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Error List, point to "Suppress Message(s)", and click 
// "In Project Suppression File".
// You do not need to add suppressions to this file manually.
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Scope = "type", Target = "Appccelerate.EventBroker.EventBroker")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.EventBroker.#AddPublication`1(System.String,System.Object,System.EventHandler`1<!!0>&,Appccelerate.EventBroker.HandlerRestriction,Appccelerate.EventBroker.Matchers.IPublicationMatcher[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.EventBroker.#AddPublication`1(System.String,System.Object,System.EventHandler`1<!!0>&,Appccelerate.EventBroker.Matchers.IPublicationMatcher[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "Appccelerate.EventBroker.EventBroker.#Appccelerate.EventBroker.IExtensionHost.ForEach(System.Action`1<Appccelerate.EventBroker.IEventBrokerExtension>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.EventBroker.#RemovePublication`1(System.String,System.Object,System.EventHandler`1<!!0>&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Appccelerate.EventBroker.EventSubscriptionAttribute")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix", Scope = "type", Target = "Appccelerate.EventBroker.EventTopicFireDelegate")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Appccelerate.EventBroker.IEventBroker.#Fire(System.String,System.Object,Appccelerate.EventBroker.HandlerRestriction,System.Object,System.EventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "register", Scope = "member", Target = "Appccelerate.EventBroker.IEventBrokerExtension.#ProcessedPublisher(System.Object,System.Boolean,Appccelerate.EventBroker.IEventTopicHost)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "register", Scope = "member", Target = "Appccelerate.EventBroker.IEventBrokerExtension.#ProcessedSubscriber(System.Object,System.Boolean,Appccelerate.EventBroker.IEventTopicHost)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Registerable", Scope = "type", Target = "Appccelerate.EventBroker.IEventBrokerRegisterable")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.IEventRegistrar.#AddPublication(System.String,System.Object,System.EventHandler&,Appccelerate.EventBroker.HandlerRestriction,Appccelerate.EventBroker.Matchers.IPublicationMatcher[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.IEventRegistrar.#AddPublication(System.String,System.Object,System.EventHandler&,Appccelerate.EventBroker.Matchers.IPublicationMatcher[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.IEventRegistrar.#AddPublication`1(System.String,System.Object,System.EventHandler`1<!!0>&,Appccelerate.EventBroker.HandlerRestriction,Appccelerate.EventBroker.Matchers.IPublicationMatcher[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.IEventRegistrar.#AddPublication`1(System.String,System.Object,System.EventHandler`1<!!0>&,Appccelerate.EventBroker.Matchers.IPublicationMatcher[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.IEventRegistrar.#RemovePublication(System.String,System.Object,System.EventHandler&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.IEventRegistrar.#RemovePublication`1(System.String,System.Object,System.EventHandler`1<!!0>&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "1#", Scope = "member", Target = "Appccelerate.EventBroker.IEventTopic.#AddPublication(System.Object,System.EventHandler&,Appccelerate.EventBroker.HandlerRestriction,System.Collections.Generic.IList`1<Appccelerate.EventBroker.Matchers.IPublicationMatcher>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "1#", Scope = "member", Target = "Appccelerate.EventBroker.IEventTopic.#AddPublication`1(System.Object,System.EventHandler`1<!!0>&,Appccelerate.EventBroker.HandlerRestriction,System.Collections.Generic.IList`1<Appccelerate.EventBroker.Matchers.IPublicationMatcher>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "1#", Scope = "member", Target = "Appccelerate.EventBroker.IEventTopic.#RemovePublication(System.Object,System.EventHandler&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "1#", Scope = "member", Target = "Appccelerate.EventBroker.IEventTopic.#RemovePublication`1(System.Object,System.EventHandler`1<!!0>&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate", Scope = "member", Target = "Appccelerate.EventBroker.IEventTopicInfo.#Fire(System.Object,System.EventArgs,Appccelerate.EventBroker.IPublication)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Appccelerate.EventBroker.IEventTopicInfo.#Uri")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Scope = "member", Target = "Appccelerate.EventBroker.ISubscription.#GetHandler()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods", Scope = "member", Target = "Appccelerate.EventBroker.ISubscription.#Handler")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Appccelerate.EventBroker.Exceptions.EventBrokerException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "Appccelerate.EventBroker.Exceptions.EventBrokerException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Appccelerate.EventBroker.Factories.StandardFactory.#AssertIsHandler(System.Type)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Appccelerate.EventBroker.Factories.StandardFactory.#AssertIsPublicationMatcher(System.Type)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Appccelerate.EventBroker.Factories.StandardFactory.#AssertIsSubscriptionMatcher(System.Type)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.Factories.StandardFactory.#CreatePublication`1(Appccelerate.EventBroker.IEventTopic,System.Object,System.EventHandler`1<!!0>&,Appccelerate.EventBroker.HandlerRestriction,System.Collections.Generic.IList`1<Appccelerate.EventBroker.Matchers.IPublicationMatcher>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "1#", Scope = "member", Target = "Appccelerate.EventBroker.Factories.StandardFactory.#DestroyPublication`1(Appccelerate.EventBroker.IPublication,System.EventHandler`1<!!0>&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Appccelerate.EventBroker.Handlers.NotUserInterfaceThreadException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Appccelerate.EventBroker.Internals.EventInspector.#HandleSubscriber(Appccelerate.EventBroker.IEventTopicHost,System.String,System.Boolean,System.Object,System.Reflection.MethodInfo,Appccelerate.EventBroker.IHandler,Appccelerate.EventBroker.Matchers.ISubscriptionMatcher[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "register", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IEventInspector.#ProcessPublisher(System.Object,System.Boolean,Appccelerate.EventBroker.IEventTopicHost)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "register", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IEventInspector.#ProcessPublisher(System.String,System.Object,System.String,Appccelerate.EventBroker.HandlerRestriction,System.Collections.Generic.IList`1<Appccelerate.EventBroker.Matchers.IPublicationMatcher>,System.Boolean,Appccelerate.EventBroker.IEventTopicHost)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "register", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IEventInspector.#ProcessSubscriber(System.Object,System.Boolean,Appccelerate.EventBroker.IEventTopicHost)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "register", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IEventInspector.#ProcessSubscriber(System.String,System.Object,System.EventHandler,Appccelerate.EventBroker.IHandler,Appccelerate.EventBroker.Matchers.ISubscriptionMatcher[],System.Boolean,Appccelerate.EventBroker.IEventTopicHost)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "register", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IEventInspector.#ProcessSubscriber`1(System.String,System.Object,System.EventHandler`1<!!0>,Appccelerate.EventBroker.IHandler,Appccelerate.EventBroker.Matchers.ISubscriptionMatcher[],System.Boolean,Appccelerate.EventBroker.IEventTopicHost)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IFactory.#CreateEventTopic(System.String,Appccelerate.EventBroker.Internals.GlobalMatchers.IGlobalMatchersProvider)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IFactory.#CreatePublication(Appccelerate.EventBroker.IEventTopic,System.Object,System.EventHandler&,Appccelerate.EventBroker.HandlerRestriction,System.Collections.Generic.IList`1<Appccelerate.EventBroker.Matchers.IPublicationMatcher>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IFactory.#CreatePublication`1(Appccelerate.EventBroker.IEventTopic,System.Object,System.EventHandler`1<!!0>&,Appccelerate.EventBroker.HandlerRestriction,System.Collections.Generic.IList`1<Appccelerate.EventBroker.Matchers.IPublicationMatcher>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "1#", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IFactory.#DestroyPublication(Appccelerate.EventBroker.IPublication,System.EventHandler&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "1#", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IFactory.#DestroyPublication`1(Appccelerate.EventBroker.IPublication,System.EventHandler`1<!!0>&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly", Scope = "type", Target = "Appccelerate.EventBroker.Internals.Exceptions.EventTopicException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Appccelerate.EventBroker.Internals.Exceptions.RepeatedSubscriptionException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Appccelerate.EventBroker.Internals.Exceptions.RepeatedSubscriptionException.#.ctor(System.Object,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Appccelerate.EventBroker.Internals.Exceptions.RepeatedPublicationException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Appccelerate.EventBroker.Internals.Exceptions.PublisherEventNotFoundException.#.ctor(System.Type,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Appccelerate.EventBroker.Internals.Exceptions.PublisherEventNotFoundException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Appccelerate.EventBroker.Internals.Exceptions.InvalidSubscriptionSignatureException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Appccelerate.EventBroker.Internals.Exceptions.InvalidPublicationSignatureException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Appccelerate.EventBroker.Internals.Exceptions.EventTopicException.#.ctor(Appccelerate.EventBroker.IEventTopic,System.Exception)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Appccelerate.EventBroker.Internals.Exceptions.InvalidPublicationSignatureException.#.ctor(System.Reflection.EventInfo)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Appccelerate.EventBroker.Internals.Exceptions.InvalidSubscriptionSignatureException.#.ctor(System.Reflection.MethodInfo)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Appccelerate.EventBroker.Internals.Exceptions.RepeatedPublicationException.#.ctor(System.Object,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Appccelerate.EventBroker.Internals.Exceptions.StaticPublisherEventException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "Appccelerate.EventBroker.Matchers.Scope.SubscribeToParents.#Match(Appccelerate.EventBroker.IPublication,Appccelerate.EventBroker.ISubscription,System.EventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "Appccelerate.EventBroker.Matchers.Scope.SubscribeToChildren.#Match(Appccelerate.EventBroker.IPublication,Appccelerate.EventBroker.ISubscription,System.EventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "Appccelerate.EventBroker.Matchers.Scope.PublishToParents.#Match(Appccelerate.EventBroker.IPublication,Appccelerate.EventBroker.ISubscription,System.EventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Appccelerate.EventBroker.Internals.Exceptions.StaticPublisherEventException.#.ctor(System.Reflection.EventInfo)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Appccelerate.EventBroker.Internals.Exceptions.StaticSubscriberHandlerException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Appccelerate.EventBroker.Internals.Exceptions.StaticSubscriberHandlerException.#.ctor(System.Reflection.MethodInfo)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "Appccelerate.EventBroker.Internals.Exceptions.SubscriberHandlerNotFoundException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Appccelerate.EventBroker.Internals.Exceptions.SubscriberHandlerNotFoundException.#.ctor(System.Type,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Appccelerate.EventBroker.Internals.Publications.PropertyPublication.#PublicationHandler(System.Object,System.EventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Scope = "type", Target = "Appccelerate.EventBroker.Matchers.IPublicationMatcher")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Scope = "type", Target = "Appccelerate.EventBroker.Matchers.ISubscriptionMatcher")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "Appccelerate.EventBroker.Matchers.Scope.PublishToChildren.#Match(Appccelerate.EventBroker.IPublication,Appccelerate.EventBroker.ISubscription,System.EventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.Factories.StandardFactory.#CreatePublication`1(Appccelerate.EventBroker.IEventTopicExecuter,System.Object,System.EventHandler`1<!!0>&,Appccelerate.EventBroker.HandlerRestriction,System.Collections.Generic.IList`1<Appccelerate.EventBroker.Matchers.IPublicationMatcher>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IFactory.#CreatePublication`1(Appccelerate.EventBroker.IEventTopicExecuter,System.Object,System.EventHandler`1<!!0>&,Appccelerate.EventBroker.HandlerRestriction,System.Collections.Generic.IList`1<Appccelerate.EventBroker.Matchers.IPublicationMatcher>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "1#", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IRegistrar.#AddPublication`1(System.Object,System.EventHandler`1<!!0>&,Appccelerate.EventBroker.HandlerRestriction,System.Collections.Generic.IList`1<Appccelerate.EventBroker.Matchers.IPublicationMatcher>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "1#", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IRegistrar.#RemovePublication(System.Object,System.EventHandler&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "1#", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IRegistrar.#RemovePublication`1(System.Object,System.EventHandler`1<!!0>&)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#", Scope = "member", Target = "Appccelerate.EventBroker.Internals.EventTopic.#.ctor(System.String,Appccelerate.EventBroker.Internals.IFactory,Appccelerate.EventBroker.IExtensionHost,Appccelerate.EventBroker.Internals.GlobalMatchers.IGlobalMatchersProvider)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "0#", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IFactory.#CreateEventTopicInternal(System.String,Appccelerate.EventBroker.Internals.GlobalMatchers.IGlobalMatchersProvider)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "2#", Scope = "member", Target = "Appccelerate.EventBroker.Internals.IFactory.#CreatePublication(Appccelerate.EventBroker.IEventTopicExecuter,System.Object,System.EventHandler&,Appccelerate.EventBroker.HandlerRestriction,System.Collections.Generic.IList`1<Appccelerate.EventBroker.Matchers.IPublicationMatcher>)")]
