// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: sign.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Server {
  public static partial class ZodiacSign
  {
    static readonly string __ServiceName = "Sign.ZodiacSign";

    static readonly grpc::Marshaller<global::Server.ZodiacRequest> __Marshaller_Sign_ZodiacRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.ZodiacRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Server.ZodiacReply> __Marshaller_Sign_ZodiacReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.ZodiacReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Server.ZodiacRequest, global::Server.ZodiacReply> __Method_GetSign = new grpc::Method<global::Server.ZodiacRequest, global::Server.ZodiacReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSign",
        __Marshaller_Sign_ZodiacRequest,
        __Marshaller_Sign_ZodiacReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Server.SignReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ZodiacSign</summary>
    public partial class ZodiacSignClient : grpc::ClientBase<ZodiacSignClient>
    {
      /// <summary>Creates a new client for ZodiacSign</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ZodiacSignClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ZodiacSign that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ZodiacSignClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ZodiacSignClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ZodiacSignClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Server.ZodiacReply GetSign(global::Server.ZodiacRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSign(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Server.ZodiacReply GetSign(global::Server.ZodiacRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSign, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ZodiacReply> GetSignAsync(global::Server.ZodiacRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSignAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Server.ZodiacReply> GetSignAsync(global::Server.ZodiacRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSign, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ZodiacSignClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ZodiacSignClient(configuration);
      }
    }

  }
}
#endregion
