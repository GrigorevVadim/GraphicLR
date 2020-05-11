namespace LR3.enums
{
    public enum EnableCap
    {
        //PointSmooth = ((int)0x0B10),
        LineSmooth = ((int)0x0B20),
        //LineStipple = ((int)0x0B24),
        PolygonSmooth = ((int)0x0B41),
        //PolygonStipple = ((int)0x0B42),
        CullFace = ((int)0x0B44),
        //Lighting = ((int)0x0B50),
        //ColorMaterial = ((int)0x0B57),
        //Fog = ((int)0x0B60),
        DepthTest = ((int)0x0B71),
        StencilTest = ((int)0x0B90),
        //Normalize = ((int)0x0BA1),
        //AlphaTest = ((int)0x0BC0),
        Dither = ((int)0x0BD0),
        Blend = ((int)0x0BE2),
        IndexLogicOp = ((int)0x0BF1),
        ColorLogicOp = ((int)0x0BF2),
        ScissorTest = ((int)0x0C11),
        /*TextureGenS = ((int)0x0C60),
        TextureGenT = ((int)0x0C61),
        TextureGenR = ((int)0x0C62),
        TextureGenQ = ((int)0x0C63),*/
        AutoNormal = ((int)0x0D80),
        Map1Color4 = ((int)0x0D90),
        Map1Index = ((int)0x0D91),
        Map1Normal = ((int)0x0D92),
        Map1TextureCoord1 = ((int)0x0D93),
        Map1TextureCoord2 = ((int)0x0D94),
        Map1TextureCoord3 = ((int)0x0D95),
        Map1TextureCoord4 = ((int)0x0D96),
        Map1Vertex3 = ((int)0x0D97),
        Map1Vertex4 = ((int)0x0D98),
        Map2Color4 = ((int)0x0DB0),
        Map2Index = ((int)0x0DB1),
        Map2Normal = ((int)0x0DB2),
        Map2TextureCoord1 = ((int)0x0DB3),
        Map2TextureCoord2 = ((int)0x0DB4),
        Map2TextureCoord3 = ((int)0x0DB5),
        Map2TextureCoord4 = ((int)0x0DB6),
        Map2Vertex3 = ((int)0x0DB7),
        Map2Vertex4 = ((int)0x0DB8),
        Texture1D = ((int)0x0DE0),
        Texture2D = ((int)0x0DE1),
        PolygonOffsetPoint = ((int)0x2A01),
        PolygonOffsetLine = ((int)0x2A02),
        ClipPlane0 = ((int)0x3000),
        ClipPlane1 = ((int)0x3001),
        ClipPlane2 = ((int)0x3002),
        ClipPlane3 = ((int)0x3003),
        ClipPlane4 = ((int)0x3004),
        ClipPlane5 = ((int)0x3005),
        /*Light0 = ((int)0x4000),
        Light1 = ((int)0x4001),
        Light2 = ((int)0x4002),
        Light3 = ((int)0x4003),
        Light4 = ((int)0x4004),
        Light5 = ((int)0x4005),
        Light6 = ((int)0x4006),
        Light7 = ((int)0x4007),*/
        Convolution1D = ((int)0x8010),
        Convolution1DExt = ((int)0x8010),
        Convolution2D = ((int)0x8011),
        Convolution2DExt = ((int)0x8011),
        Separable2D = ((int)0x8012),
        Separable2DExt = ((int)0x8012),
        Histogram = ((int)0x8024),
        HistogramExt = ((int)0x8024),
        MinmaxExt = ((int)0x802E),
        PolygonOffsetFill = ((int)0x8037),
        //RescaleNormal = ((int)0x803A),
        RescaleNormalExt = ((int)0x803A),
        Texture3DExt = ((int)0x806F),
        VertexArray = ((int)0x8074),
        NormalArray = ((int)0x8075),
        ColorArray = ((int)0x8076),
        IndexArray = ((int)0x8077),
        TextureCoordArray = ((int)0x8078),
        EdgeFlagArray = ((int)0x8079),
        InterlaceSgix = ((int)0x8094),
        Multisample = ((int)0x809D),
        SampleAlphaToCoverage = ((int)0x809E),
        SampleAlphaToMaskSgis = ((int)0x809E),
        SampleAlphaToOne = ((int)0x809F),
        SampleAlphaToOneSgis = ((int)0x809F),
        SampleCoverage = ((int)0x80A0),
        SampleMaskSgis = ((int)0x80A0),
        TextureColorTableSgi = ((int)0x80BC),
        ColorTable = ((int)0x80D0),
        ColorTableSgi = ((int)0x80D0),
        PostConvolutionColorTable = ((int)0x80D1),
        PostConvolutionColorTableSgi = ((int)0x80D1),
        PostColorMatrixColorTable = ((int)0x80D2),
        PostColorMatrixColorTableSgi = ((int)0x80D2),
        Texture4DSgis = ((int)0x8134),
        PixelTexGenSgix = ((int)0x8139),
        SpriteSgix = ((int)0x8148),
        ReferencePlaneSgix = ((int)0x817D),
        IrInstrument1Sgix = ((int)0x817F),
        CalligraphicFragmentSgix = ((int)0x8183),
        FramezoomSgix = ((int)0x818B),
        FogOffsetSgix = ((int)0x8198),
        SharedTexturePaletteExt = ((int)0x81FB),
        AsyncHistogramSgix = ((int)0x832C),
        PixelTextureSgis = ((int)0x8353),
        AsyncTexImageSgix = ((int)0x835C),
        AsyncDrawPixelsSgix = ((int)0x835D),
        AsyncReadPixelsSgix = ((int)0x835E),
        FragmentLightingSgix = ((int)0x8400),
        FragmentColorMaterialSgix = ((int)0x8401),
        FragmentLight0Sgix = ((int)0x840C),
        FragmentLight1Sgix = ((int)0x840D),
        FragmentLight2Sgix = ((int)0x840E),
        FragmentLight3Sgix = ((int)0x840F),
        FragmentLight4Sgix = ((int)0x8410),
        FragmentLight5Sgix = ((int)0x8411),
        FragmentLight6Sgix = ((int)0x8412),
        FragmentLight7Sgix = ((int)0x8413),
        //FogCoordArray = ((int)0x8457),
        ColorSum = ((int)0x8458),
        SecondaryColorArray = ((int)0x845E),
        TextureCubeMap = ((int)0x8513),
        ProgramPointSize = ((int)0x8642),
        VertexProgramPointSize = ((int)0x8642),
        //VertexProgramTwoSide = ((int)0x8643),
        DepthClamp = ((int)0x864F),
        TextureCubeMapSeamless = ((int)0x884F),
        PointSprite = ((int)0x8861),
        RasterizerDiscard = ((int)0x8C89),
        FramebufferSrgb = ((int)0x8DB9),
        SampleMask = ((int)0x8E51),
        PrimitiveRestart = ((int)0x8F9D),
    }
}