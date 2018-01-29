namespace System.Runtime.CompilerServices {
    internal class __BlockReflectionAttribute : Attribute { }
}

namespace Microsoft.Xml.Serialization.GeneratedAssembly {


    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write5_MallKioskDemoSettings(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"MallKioskDemoSettings", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace1 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write4_MallKioskDemoSettings(@"MallKioskDemoSettings", namespace1, ((global::IntelligentKioskSample.MallKioskPageConfig.MallKioskDemoSettings)o), true, false, namespace1, @"");
        }

        void Write4_MallKioskDemoSettings(string n, string ns, global::IntelligentKioskSample.MallKioskPageConfig.MallKioskDemoSettings o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::IntelligentKioskSample.MallKioskPageConfig.MallKioskDemoSettings)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"MallKioskDemoSettings", defaultNamespace);
            string namespace2 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation> a = (global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation>)((global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation>)o.@GenericRecommendations);
                if (a != null){
                    WriteStartElement(@"GenericRecommendations", namespace2, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace3 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write3_Recommendation(@"Recommendation", namespace3, ((global::IntelligentKioskSample.MallKioskPageConfig.Recommendation)a[ia]), true, false, namespace3, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace4 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation> a = (global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation>)((global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation>)o.@PersonalizedRecommendations);
                if (a != null){
                    WriteStartElement(@"PersonalizedRecommendations", namespace4, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace5 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write3_Recommendation(@"Recommendation", namespace5, ((global::IntelligentKioskSample.MallKioskPageConfig.Recommendation)a[ia]), true, false, namespace5, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write3_Recommendation(string n, string ns, global::IntelligentKioskSample.MallKioskPageConfig.Recommendation o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::IntelligentKioskSample.MallKioskPageConfig.Recommendation)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Recommendation", defaultNamespace);
            WriteAttribute(@"Id", @"", ((global::System.String)o.@Id));
            WriteAttribute(@"Url", @"", ((global::System.String)o.@Url));
            string namespace6 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction> a = (global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction>)((global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction>)o.@SpeechKeywordBehavior);
                if (a != null){
                    WriteStartElement(@"SpeechKeywordBehavior", namespace6, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace7 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write2_BehaviorAction(@"BehaviorAction", namespace7, ((global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction)a[ia]), true, false, namespace7, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace8 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction> a = (global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction>)((global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction>)o.@SpeechSentimentBehavior);
                if (a != null){
                    WriteStartElement(@"SpeechSentimentBehavior", namespace8, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace9 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write2_BehaviorAction(@"BehaviorAction", namespace9, ((global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction)a[ia]), true, false, namespace9, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write2_BehaviorAction(string n, string ns, global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"BehaviorAction", defaultNamespace);
            WriteAttribute(@"Key", @"", ((global::System.String)o.@Key));
            WriteAttribute(@"Url", @"", ((global::System.String)o.@Url));
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read5_MallKioskDemoSettings(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_MallKioskDemoSettings && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read4_MallKioskDemoSettings(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":MallKioskDemoSettings");
            }
            return (object)o;
        }

        global::IntelligentKioskSample.MallKioskPageConfig.MallKioskDemoSettings Read4_MallKioskDemoSettings(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_MallKioskDemoSettings && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::IntelligentKioskSample.MallKioskPageConfig.MallKioskDemoSettings o;
            o = new global::IntelligentKioskSample.MallKioskPageConfig.MallKioskDemoSettings();
            if ((object)(o.@GenericRecommendations) == null) o.@GenericRecommendations = new global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation>();
            global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation> a_0 = (global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation>)o.@GenericRecommendations;
            if ((object)(o.@PersonalizedRecommendations) == null) o.@PersonalizedRecommendations = new global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation>();
            global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation> a_1 = (global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation>)o.@PersonalizedRecommendations;
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (((object) Reader.LocalName == (object)id3_GenericRecommendations && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        if (!ReadNull()) {
                            if ((object)(o.@GenericRecommendations) == null) o.@GenericRecommendations = new global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation>();
                            global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation> a_0_0 = (global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation>)o.@GenericRecommendations;
                            if ((Reader.IsEmptyElement)) {
                                Reader.Skip();
                            }
                            else {
                                Reader.ReadStartElement();
                                Reader.MoveToContent();
                                int whileIterations1 = 0;
                                int readerCount1 = ReaderCount;
                                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                        if (((object) Reader.LocalName == (object)id4_Recommendation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                            if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read3_Recommendation(true, true, defaultNamespace));
                                        }
                                        else {
                                            UnknownNode(null, @":Recommendation");
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":Recommendation");
                                    }
                                    Reader.MoveToContent();
                                    CheckReaderCount(ref whileIterations1, ref readerCount1);
                                }
                            ReadEndElement();
                            }
                        }
                    }
                    else if (((object) Reader.LocalName == (object)id5_PersonalizedRecommendations && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        if (!ReadNull()) {
                            if ((object)(o.@PersonalizedRecommendations) == null) o.@PersonalizedRecommendations = new global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation>();
                            global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation> a_1_0 = (global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.Recommendation>)o.@PersonalizedRecommendations;
                            if ((Reader.IsEmptyElement)) {
                                Reader.Skip();
                            }
                            else {
                                Reader.ReadStartElement();
                                Reader.MoveToContent();
                                int whileIterations2 = 0;
                                int readerCount2 = ReaderCount;
                                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                        if (((object) Reader.LocalName == (object)id4_Recommendation && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                            if ((object)(a_1_0) == null) Reader.Skip(); else a_1_0.Add(Read3_Recommendation(true, true, defaultNamespace));
                                        }
                                        else {
                                            UnknownNode(null, @":Recommendation");
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":Recommendation");
                                    }
                                    Reader.MoveToContent();
                                    CheckReaderCount(ref whileIterations2, ref readerCount2);
                                }
                            ReadEndElement();
                            }
                        }
                    }
                    else {
                        UnknownNode((object)o, @":GenericRecommendations, :PersonalizedRecommendations");
                    }
                }
                else {
                    UnknownNode((object)o, @":GenericRecommendations, :PersonalizedRecommendations");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            ReadEndElement();
            return o;
        }

        global::IntelligentKioskSample.MallKioskPageConfig.Recommendation Read3_Recommendation(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Recommendation && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::IntelligentKioskSample.MallKioskPageConfig.Recommendation o;
            o = new global::IntelligentKioskSample.MallKioskPageConfig.Recommendation();
            if ((object)(o.@SpeechKeywordBehavior) == null) o.@SpeechKeywordBehavior = new global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction>();
            global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction> a_2 = (global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction>)o.@SpeechKeywordBehavior;
            if ((object)(o.@SpeechSentimentBehavior) == null) o.@SpeechSentimentBehavior = new global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction>();
            global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction> a_3 = (global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction>)o.@SpeechSentimentBehavior;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id6_Id && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Id = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id7_Url && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Url = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Id, :Url");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations3 = 0;
            int readerCount3 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (((object) Reader.LocalName == (object)id8_SpeechKeywordBehavior && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        if (!ReadNull()) {
                            if ((object)(o.@SpeechKeywordBehavior) == null) o.@SpeechKeywordBehavior = new global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction>();
                            global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction> a_2_0 = (global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction>)o.@SpeechKeywordBehavior;
                            if ((Reader.IsEmptyElement)) {
                                Reader.Skip();
                            }
                            else {
                                Reader.ReadStartElement();
                                Reader.MoveToContent();
                                int whileIterations4 = 0;
                                int readerCount4 = ReaderCount;
                                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                        if (((object) Reader.LocalName == (object)id9_BehaviorAction && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                            if ((object)(a_2_0) == null) Reader.Skip(); else a_2_0.Add(Read2_BehaviorAction(true, true, defaultNamespace));
                                        }
                                        else {
                                            UnknownNode(null, @":BehaviorAction");
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":BehaviorAction");
                                    }
                                    Reader.MoveToContent();
                                    CheckReaderCount(ref whileIterations4, ref readerCount4);
                                }
                            ReadEndElement();
                            }
                        }
                    }
                    else if (((object) Reader.LocalName == (object)id10_SpeechSentimentBehavior && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        if (!ReadNull()) {
                            if ((object)(o.@SpeechSentimentBehavior) == null) o.@SpeechSentimentBehavior = new global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction>();
                            global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction> a_3_0 = (global::System.Collections.Generic.List<global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction>)o.@SpeechSentimentBehavior;
                            if ((Reader.IsEmptyElement)) {
                                Reader.Skip();
                            }
                            else {
                                Reader.ReadStartElement();
                                Reader.MoveToContent();
                                int whileIterations5 = 0;
                                int readerCount5 = ReaderCount;
                                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                        if (((object) Reader.LocalName == (object)id9_BehaviorAction && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                            if ((object)(a_3_0) == null) Reader.Skip(); else a_3_0.Add(Read2_BehaviorAction(true, true, defaultNamespace));
                                        }
                                        else {
                                            UnknownNode(null, @":BehaviorAction");
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":BehaviorAction");
                                    }
                                    Reader.MoveToContent();
                                    CheckReaderCount(ref whileIterations5, ref readerCount5);
                                }
                            ReadEndElement();
                            }
                        }
                    }
                    else {
                        UnknownNode((object)o, @":SpeechKeywordBehavior, :SpeechSentimentBehavior");
                    }
                }
                else {
                    UnknownNode((object)o, @":SpeechKeywordBehavior, :SpeechSentimentBehavior");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations3, ref readerCount3);
            }
            ReadEndElement();
            return o;
        }

        global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction Read2_BehaviorAction(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_BehaviorAction && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction o;
            o = new global::IntelligentKioskSample.MallKioskPageConfig.BehaviorAction();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id11_Key && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Key = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id7_Url && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Url = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Key, :Url");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations6 = 0;
            int readerCount6 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations6, ref readerCount6);
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id7_Url;
        string id4_Recommendation;
        string id11_Key;
        string id6_Id;
        string id1_MallKioskDemoSettings;
        string id8_SpeechKeywordBehavior;
        string id5_PersonalizedRecommendations;
        string id2_Item;
        string id9_BehaviorAction;
        string id3_GenericRecommendations;
        string id10_SpeechSentimentBehavior;

        protected override void InitIDs() {
            id7_Url = Reader.NameTable.Add(@"Url");
            id4_Recommendation = Reader.NameTable.Add(@"Recommendation");
            id11_Key = Reader.NameTable.Add(@"Key");
            id6_Id = Reader.NameTable.Add(@"Id");
            id1_MallKioskDemoSettings = Reader.NameTable.Add(@"MallKioskDemoSettings");
            id8_SpeechKeywordBehavior = Reader.NameTable.Add(@"SpeechKeywordBehavior");
            id5_PersonalizedRecommendations = Reader.NameTable.Add(@"PersonalizedRecommendations");
            id2_Item = Reader.NameTable.Add(@"");
            id9_BehaviorAction = Reader.NameTable.Add(@"BehaviorAction");
            id3_GenericRecommendations = Reader.NameTable.Add(@"GenericRecommendations");
            id10_SpeechSentimentBehavior = Reader.NameTable.Add(@"SpeechSentimentBehavior");
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class MallKioskDemoSettingsSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"MallKioskDemoSettings", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write5_MallKioskDemoSettings(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read5_MallKioskDemoSettings(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System.Collections.IDictionary readMethods = null;
        public override System.Collections.IDictionary ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                    _tmp[@"IntelligentKioskSample.MallKioskPageConfig.MallKioskDemoSettings:::True:"] = @"Read5_MallKioskDemoSettings";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.IDictionary writeMethods = null;
        public override System.Collections.IDictionary WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                    _tmp[@"IntelligentKioskSample.MallKioskPageConfig.MallKioskDemoSettings:::True:"] = @"Write5_MallKioskDemoSettings";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.IDictionary typedSerializers = null;
        public override System.Collections.IDictionary TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, System.Xml.Serialization.XmlSerializer>();
                    _tmp.Add(@"IntelligentKioskSample.MallKioskPageConfig.MallKioskDemoSettings:::True:", new MallKioskDemoSettingsSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::IntelligentKioskSample.MallKioskPageConfig.MallKioskDemoSettings)) return true;
            if (type == typeof(global::System.Reflection.TypeInfo)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::IntelligentKioskSample.MallKioskPageConfig.MallKioskDemoSettings)) return new MallKioskDemoSettingsSerializer();
            return null;
        }
        public static global::System.Xml.Serialization.XmlSerializerImplementation GetXmlSerializerContract() { return new XmlSerializerContract(); }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public static class ActivatorHelper {
        public static object CreateInstance(System.Type type) {
            System.Reflection.TypeInfo ti = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
            foreach (System.Reflection.ConstructorInfo ci in ti.DeclaredConstructors) {
                if (!ci.IsStatic && ci.GetParameters().Length == 0) {
                    return ci.Invoke(null);
                }
            }
            return System.Activator.CreateInstance(type);
        }
    }
}
