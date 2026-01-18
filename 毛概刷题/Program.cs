using System;
using System.Collections.Generic;

namespace 毛概刷题
{
    class Question
    {
        public string Text { get; set; }
        public string Type { get; set; } // "Choice", "Fill", "Judge"
        public string Answer { get; set; }
        public string Options { get; set; } // 仅用于选择题

        public Question(string text, string type, string answer, string options = "")
        {
            Text = text;
            Type = type;
            Answer = answer;
            Options = options;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "毛概高频重难点刷题系统 - 最强大脑版";
            List<Question> bank = InitializeQuestionBank();

            Console.WriteLine("====================================================");
            Console.WriteLine("       毛概重难点高频考点刷题程序 (VS2022版)       ");
            Console.WriteLine("  规则：错题需重答，对题进下一关。祝你高分通过！   ");
            Console.WriteLine("  输入提示：判断题(1对2错), 选择题(ABCD), 填空(关键词) ");
            Console.WriteLine("====================================================\n");

            int count = 1;
            foreach (var q in bank)
            {
                bool isCorrect = false;
                while (!isCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"【第 {count} 题 - {GetTypeName(q.Type)}】");
                    Console.ResetColor();
                    Console.WriteLine(q.Text);
                    if (!string.IsNullOrEmpty(q.Options)) Console.WriteLine(q.Options);

                    Console.Write("你的答案: ");
                    string userInput = Console.ReadLine()?.Trim().ToUpper();

                    if (userInput == q.Answer.ToUpper())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("√ 回答正确！进入下一题。\n");
                        Console.ResetColor();
                        isCorrect = true;
                        count++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("× 答案错误，请仔细思考后重新回答。");
                        Console.ResetColor();
                    }
                }
            }

            Console.WriteLine("====================================================");
            Console.WriteLine("恭喜！你已完成所有高频考点训练！");
            Console.ReadLine();
        }

        static string GetTypeName(string type) => type switch
        {
            "Choice" => "选择题",
            "Fill" => "填空题",
            "Judge" => "判断题",
            _ => "题目"
        };

        static List<Question> InitializeQuestionBank()
        {
            return new List<Question>
            {
                // 第一章
                new Question("最早提出“马克思主义中国化”命题的会议是？", "Choice", "B", "A.中共七大 B.六届六中全会 C.遵义会议 D.十一届三中全会"),
                new Question("1938年毛泽东在哪篇报告中提出“使马克思主义在中国具体化”？", "Choice", "A", "A.《论新阶段》 B.《新民主主义论》 C.《实践论》 D.《论联合政府》"),
                new Question("毛泽东思想是党集体智慧的结晶，等于毛泽东个人的全部思想。", "Judge", "2", ""),
                new Question("毛泽东思想是马克思主义中国化第几次历史性飞跃的理论成果？", "Choice", "A", "A.第一次 B.第二次 C.第三次 D.第四次"),
                new Question("毛泽东思想的活的灵魂不包括？", "Choice", "D", "A.实事求是 B.群众路线 C.独立自主 D.武装斗争"),
                new Question("毛泽东思想的精髓是？", "Choice", "A", "A.实事求是 B.群众路线 C.独立自主 D.党的建设"),
                new Question("群众路线是党的生命线和根本工作路线。", "Judge", "1", ""),
                new Question("独立自主是毛泽东思想的立足点，主要依靠自己力量。", "Judge", "1", ""),
                new Question("历史发展和社会进步的主体力量是？", "Choice", "B", "A.英雄人物 B.人民群众 C.知识分子 D.无产阶级"),
                new Question("毛泽东思想开始萌芽于哪个时期？", "Choice", "A", "A.大革命时期 B.土地革命时期 C.抗日战争时期 D.解放战争时期"),
                new Question("《中国的红色政权为什么能够存在？》标志着毛泽东思想成熟。", "Judge", "2", ""), // 应该是初步形成
                new Question("毛泽东思想走向成熟的标志是？", "Choice", "C", "A.提出工农武装割据 B.提出群众路线 C.系统阐述新民主主义革命理论 D.提出社会主义建设道路"),
                new Question("中共七大明确把毛泽东思想作为党的指导思想写进党章。", "Judge", "1", ""),
                new Question("实事求是是马克思主义的根本观点，是中国共产党人的思想路线。", "Judge", "1", ""),
                new Question("马克思主义中国化时代化的第一个重大理论成果是？", "Choice", "B", "A.三民主义 B.毛泽东思想 C.邓小平理论 D.科学发展观"),

                // --- 第二章 新民主主义革命 ---
                new Question("近代中国最主要的矛盾是？", "Choice", "A", "A.帝国主义与中华民族的矛盾 B.封建主义与农民阶级的矛盾 C.无产阶级与资产阶级的矛盾"),
                new Question("新民主主义革命的领导核心是？", "Choice", "B", "A.农民阶级 B.无产阶级 C.民族资产阶级 D.城市小资产阶级"),
                new Question("区分新旧民主主义革命的根本标志是？", "Choice", "C", "A.革命对象 B.革命动力 C.领导权 D.革命前途"),
                new Question("五四运动标志着新民主主义革命的开端。", "Judge", "1", ""),
                new Question("新民主主义革命的性质是社会主义革命。", "Judge", "2", ""), // 应该是资产阶级民主主义革命
                new Question("新民主主义革命的经济纲领中，对民族工商业采取什么政策？", "Choice", "C", "A.没收归国家 B.没收归农民 C.保护 D.限制"),
                new Question("没收封建地主土地归农民所有是新民主主义革命的政治纲领。", "Judge", "2", ""), // 是经济纲领
                new Question("新民主主义文化是民族的、科学的、大众的文化。", "Judge", "1", ""),
                new Question("农村根据地能够长期生存的根本原因是？", "Choice", "D", "A.红军强大 B.党的领导 C.农民支持 D.半殖民地半封建大国国情"),
                new Question("新民主主义革命的三大法宝是：统一战线、武装斗争、党的建设。", "Judge", "1", ""),
                new Question("统一战线的基础是工农联盟。", "Judge", "1", ""),
                new Question("无产阶级实现革命领导权的关键是建立广泛的统一战线。", "Judge", "1", ""),
                new Question("新民主主义革命的直接前途是社会主义社会。", "Judge", "2", ""), // 直接前途是新民主主义社会
                new Question("中国革命的主要形式是武装斗争。", "Judge", "1", ""),
                new Question("新民主主义革命理论的初创时期是土地革命战争时期。", "Judge", "1", ""),

                // --- 第三章 社会主义改造 ---
                new Question("新中国成立到社会主义改造完成的社会性质是？", "Choice", "B", "A.封建社会 B.新民主主义社会 C.社会主义社会 D.资本主义社会"),
                new Question("新民主主义社会是一个独立的社会形态。", "Judge", "2", ""), // 是过渡性社会
                new Question("党在过渡时期的总路线简称“一化三改”，其中“一化”指？", "Choice", "A", "A.工业化 B.现代化 C.农业化 D.集体化"),
                new Question("对农业的社会主义改造经历了互助组、初级社、高级社三个阶段。", "Judge", "1", ""),
                new Question("农业社会主义改造中，具有半社会主义性质的是？", "Choice", "B", "A.互助组 B.初级社 C.高级社 D.人民公社"),
                new Question("对资本主义工商业改造采取的政策是？", "Choice", "C", "A.强制没收 B.低价收购 C.和平赎买 D.自由竞争"),
                new Question("全行业公私合营是社会主义改造基本完成的标志。", "Judge", "1", ""),
                new Question("社会主义基本制度在我国确立的时间是？", "Choice", "C", "A.1949年 B.1953年 C.1956年 D.1958年"),
                new Question("社会主义基本制度的确立标志着中国进入了社会主义初级阶段。", "Judge", "1", ""),
                new Question("个体手工业改造的方法步骤是由低级到高级的三个步骤。", "Judge", "1", ""),
                new Question("我国已经有了相对强大的社会主义国营经济是过渡路线的物质基础。", "Judge", "1", ""),
                new Question("新民主主义社会中居于领导地位的经济成分是国营经济。", "Judge", "1", ""),

                // --- 第四章 社会主义建设探索 ---
                new Question("《论十大关系》确定的基本方针是调动一切积极因素为社会主义事业服务。", "Judge", "1", ""),
                new Question("中国工业化道路中最重要的问题是处理好重工业和轻工业、农业的关系。", "Judge", "1", ""),
                new Question("社会主义社会政治生活的主题是正确处理两类不同性质的矛盾。", "Judge", "1", ""),
                new Question("处理人民内部矛盾的总方针是？", "Choice", "B", "A.专政 B.民主 C.教育 D.批评"),
                new Question("敌我矛盾是对抗性的矛盾。", "Judge", "1", ""),
                new Question("两类不同性质的矛盾在一定条件下可以互相转化。", "Judge", "1", ""),
                new Question("社会主义社会的基本矛盾是？", "Choice", "D", "A.阶级斗争 B.落后生产 C.中外矛盾 D.生产力与生产关系、经济基础与上层建筑"),
                new Question("“百花齐放、百家争鸣”是处理科学文化领域矛盾的方针。", "Judge", "1", ""),
                new Question("毛泽东提出，处理共产党和民主党派矛盾的方针是？", "Choice", "C", "A.团结奋斗 B.肝胆相照 C.长期共存、互相监督 D.统筹兼顾"),
                new Question("解决敌我矛盾的方法是专政。", "Judge", "1", ""),
                new Question("1954年宪法的确立从根本上保证了人民当家作主的权利。", "Judge", "1", ""),
                new Question("探索社会主义建设道路必须把马克思主义与中国实际进行“第二次结合”。", "Judge", "1", ""),

                // --- 第五至八章 邓、三、科 ---
                new Question("明确提出“建设有中国特色的社会主义”命题的会议是？", "Choice", "B", "A.中共十一届三中全会 B.中共十二大 C.中共十三大 D.中共十四大"),
                new Question("邓小平理论形成的时代背景是？", "Choice", "C", "A.战争与革命 B.动荡与变革 C.和平与发展 D.合作与共赢"),
                new Question("社会主义初级阶段理论是在哪次会议上系统论述的？", "Choice", "B", "A.中共十二大 B.中共十三大 C.中共十四大 D.中共十五大"),
                new Question("邓小平理论的首要基本理论问题是：什么是社会主义、怎样建设社会主义。", "Judge", "1", ""),
                new Question("社会主义的本质不包括？", "Choice", "D", "A.解放和发展生产力 B.消灭剥削 C.最终达到共同富裕 D.实现同步富裕"),
                new Question("判断改革开放和各项工作是非得失的标准是？", "Choice", "A", "A.“三个有利于” B.公平正义 C.GDP增长 D.国际声誉"),
                new Question("改革是社会主义制度的自我完善和发展。", "Judge", "1", ""),
                new Question("对外开放是建设中国特色社会主义的一项基本国策。", "Judge", "1", ""),
                new Question("邓小平理论被确立为党的指导思想并写入党章是在？", "Choice", "C", "A.中共十二大 B.中共十四大 C.中共十五大 D.中共十六大"),
                new Question("“三个代表”重要思想的关键是与时俱进。", "Judge", "1", ""),
                new Question("“三个代表”重要思想的核心是坚持党的先进性。", "Judge", "1", ""),
                new Question("“三个代表”重要思想的本质是立党为公、执政为民。", "Judge", "1", ""),
                new Question("科学发展观的第一要义是？", "Choice", "A", "A.发展 B.以人为本 C.统筹兼顾 D.全面协调"),
                new Question("科学发展观的核心是？", "Choice", "B", "A.发展 B.以人为本 C.统筹兼顾 D.可持续"),
                new Question("科学发展观的基本要求是？", "Choice", "C", "A.发展 B.以人为本 C.全面协调可持续 D.统筹兼顾"),
                new Question("科学发展观的根本方法是？", "Choice", "D", "A.发展 B.以人为本 C.全面协调 D.统筹兼顾"),
                new Question("中国特色社会主义理论体系是马克思主义中国化的第二次历史性飞跃。", "Judge", "1", ""),
                new Question("公有制经济与非公有制经济都是社会主义市场经济的重要组成部分。", "Judge", "1", ""),

                // --- 高频陷阱与补充知识 ---
                new Question("党的十一届三中全会重新确立的思想路线是？", "Choice", "A", "A.解放思想、实事求是 B.求真务实 C.与时俱进 D.开拓创新"),
                new Question("习近平新时代中国特色社会主义思想明确当前社会主要矛盾是？", "Choice", "B", "A.落后的生产力 B.美好生活需要与不平衡不充分的发展 C.阶级斗争 D.经济发展与环保"),
                new Question("党的建设始终把什么建设放在首位？", "Choice", "C", "A.组织建设 B.作风建设 C.思想建设 D.纪律建设"),
                new Question("农民问题是中国革命的中心问题。", "Judge", "1", ""),
                new Question("无产阶级是新民主主义革命唯一的领导者。", "Judge", "1", ""),
                new Question("新民主主义革命的指导思想是马克思列宁主义。", "Judge", "1", ""),
                new Question("新民主主义革命的最终前途是社会主义社会。", "Judge", "1", ""),
                new Question("“三步走”战略中，第二步的目标是生活达到中等发达国家水平。", "Judge", "2", ""), // 是达到小康水平
                new Question("对外开放要处理好的关系中，必须坚持独立自主、自力更生。", "Judge", "1", ""),
                new Question("马克思主义中国化的最新成果是习近平新时代中国特色社会主义思想。", "Judge", "1", ""),
                new Question("邓小平提出“科学技术是第一生产力”。", "Judge", "1", ""),
                new Question("社会主义的根本任务是发展生产力。", "Judge", "1", ""),
                new Question("“两手抓，两手都要硬”是指一手抓物质文明，一手抓精神文明。", "Judge", "1", ""),
                new Question("中国特色社会主义理论体系不包括毛泽东思想。", "Judge", "1", ""), // 这是一个常考概念：毛是第一个，体系是第二个，第二个包含邓三科习
                new Question("发展是党执政兴国的第一要务。", "Judge", "1", ""),
                new Question("建立社会主义市场经济体制是在中共十四大明确提出的。", "Judge", "1", ""),
                new Question("加快转变经济发展方式是科学发展观的主要内容之一。", "Judge", "1", ""),
                new Question("构建社会主义和谐社会是科学发展观的延伸内容。", "Judge", "1", ""),
                new Question("没收官僚资本归国家所有具有民主革命和社会主义革命的双重性质。", "Judge", "1", ""),
                new Question("近代中国社会的性质是半殖民地半封建社会。", "Judge", "1", ""),
                new Question("中国革命走农村包围城市道路的根本在于处理好工农关系。", "Judge", "2", ""), // 是处理好土地革命、武装斗争、根据地建设的关系
                new Question("土地革命是中国革命的主要形式。", "Judge", "2", ""), // 主要形式是武装斗争
                new Question("农村革命根据地是中国革命的战略阵地。", "Judge", "1", ""),
                new Question("“引进来”和“走出去”相结合是对外开放战略的内容。", "Judge", "1", ""),
                new Question("我国处于社会主义初级阶段是最大的实际。", "Judge", "1", ""),
                new Question("实事求是是马克思主义中国化理论成果的精髓。", "Judge", "1", ""),
                new Question("毛泽东在《论十大关系》中提出了“以苏为鉴”。", "Judge", "1", ""),
                new Question("毛泽东思想关于党的建设最突出的核心内容是着重从思想上建党。", "Judge", "1", ""),
                new Question("马克思主义理论本身发展的内在要求是马克思主义中国化的动力。", "Judge", "1", ""),
                new Question("解决中国实际问题的客观需要是马克思主义中国化的根本原因。", "Judge", "1", "")
            };
        }
    }
}


