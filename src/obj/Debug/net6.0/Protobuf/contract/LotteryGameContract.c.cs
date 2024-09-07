// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protobuf/contract/lottery_game_contract.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using System.Collections.Generic;
using aelf = global::AElf.CSharp.Core;

namespace AElf.Contracts.LotteryGame {

  #region Events
  public partial class PlayOutcomeEvent : aelf::IEvent<PlayOutcomeEvent>
  {
    public global::System.Collections.Generic.IEnumerable<PlayOutcomeEvent> GetIndexed()
    {
      return new List<PlayOutcomeEvent>
      {
      };
    }

    public PlayOutcomeEvent GetNonIndexed()
    {
      return new PlayOutcomeEvent
      {
        Amount = Amount,
        Won = Won,
      };
    }
  }

  public partial class WithdrawEvent : aelf::IEvent<WithdrawEvent>
  {
    public global::System.Collections.Generic.IEnumerable<WithdrawEvent> GetIndexed()
    {
      return new List<WithdrawEvent>
      {
      };
    }

    public WithdrawEvent GetNonIndexed()
    {
      return new WithdrawEvent
      {
        Amount = Amount,
        From = From,
        To = To,
      };
    }
  }

  public partial class DepositEvent : aelf::IEvent<DepositEvent>
  {
    public global::System.Collections.Generic.IEnumerable<DepositEvent> GetIndexed()
    {
      return new List<DepositEvent>
      {
      };
    }

    public DepositEvent GetNonIndexed()
    {
      return new DepositEvent
      {
        Amount = Amount,
        From = From,
        To = To,
      };
    }
  }

  #endregion
  public static partial class LotteryGameContainer
  {
    static readonly string __ServiceName = "LotteryGame";

    #region Marshallers
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.Int64Value> __Marshaller_google_protobuf_Int64Value = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Int64Value.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Types.Address> __Marshaller_aelf_Address = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Types.Address.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::AElf.Contracts.LotteryGame.PlayAmountLimitMessage> __Marshaller_PlayAmountLimitMessage = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::AElf.Contracts.LotteryGame.PlayAmountLimitMessage.Parser.ParseFrom);
    static readonly aelf::Marshaller<global::Google.Protobuf.WellKnownTypes.StringValue> __Marshaller_google_protobuf_StringValue = aelf::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.StringValue.Parser.ParseFrom);
    #endregion

    #region Methods
    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Initialize = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Initialize",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Play = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Play",
        __Marshaller_google_protobuf_Int64Value,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Withdraw = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Withdraw",
        __Marshaller_google_protobuf_Int64Value,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Deposit = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Int64Value, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "Deposit",
        __Marshaller_google_protobuf_Int64Value,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty> __Method_TransferOwnership = new aelf::Method<global::AElf.Types.Address, global::Google.Protobuf.WellKnownTypes.Empty>(
        aelf::MethodType.Action,
        __ServiceName,
        "TransferOwnership",
        __Marshaller_aelf_Address,
        __Marshaller_google_protobuf_Empty);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.LotteryGame.PlayAmountLimitMessage> __Method_GetPlayAmountLimit = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::AElf.Contracts.LotteryGame.PlayAmountLimitMessage>(
        aelf::MethodType.View,
        __ServiceName,
        "GetPlayAmountLimit",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_PlayAmountLimitMessage);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value> __Method_GetContractBalance = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.Int64Value>(
        aelf::MethodType.View,
        __ServiceName,
        "GetContractBalance",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_Int64Value);

    static readonly aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue> __Method_GetOwner = new aelf::Method<global::Google.Protobuf.WellKnownTypes.Empty, global::Google.Protobuf.WellKnownTypes.StringValue>(
        aelf::MethodType.View,
        __ServiceName,
        "GetOwner",
        __Marshaller_google_protobuf_Empty,
        __Marshaller_google_protobuf_StringValue);

    #endregion

    #region Descriptors
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AElf.Contracts.LotteryGame.LotteryGameContractReflection.Descriptor.Services[0]; }
    }

    public static global::System.Collections.Generic.IReadOnlyList<global::Google.Protobuf.Reflection.ServiceDescriptor> Descriptors
    {
      get
      {
        return new global::System.Collections.Generic.List<global::Google.Protobuf.Reflection.ServiceDescriptor>()
        {
          global::AElf.Standards.ACS12.Acs12Reflection.Descriptor.Services[0],
          global::AElf.Contracts.LotteryGame.LotteryGameContractReflection.Descriptor.Services[0],
        };
      }
    }
    #endregion

    /// <summary>Base class for the contract of LotteryGame</summary>
    public abstract partial class LotteryGameBase : AElf.Sdk.CSharp.CSharpSmartContract<AElf.Contracts.LotteryGame.LotteryGameState>
    {
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Initialize(global::Google.Protobuf.WellKnownTypes.Empty input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty Play(global::Google.Protobuf.WellKnownTypes.Int64Value input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty Withdraw(global::Google.Protobuf.WellKnownTypes.Int64Value input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty Deposit(global::Google.Protobuf.WellKnownTypes.Int64Value input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Empty TransferOwnership(global::AElf.Types.Address input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::AElf.Contracts.LotteryGame.PlayAmountLimitMessage GetPlayAmountLimit(global::Google.Protobuf.WellKnownTypes.Empty input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.Int64Value GetContractBalance(global::Google.Protobuf.WellKnownTypes.Empty input)
      {
        throw new global::System.NotImplementedException();
      }

      public virtual global::Google.Protobuf.WellKnownTypes.StringValue GetOwner(global::Google.Protobuf.WellKnownTypes.Empty input)
      {
        throw new global::System.NotImplementedException();
      }

    }

    public static aelf::ServerServiceDefinition BindService(LotteryGameBase serviceImpl)
    {
      return aelf::ServerServiceDefinition.CreateBuilder()
          .AddDescriptors(Descriptors)
          .AddMethod(__Method_Initialize, serviceImpl.Initialize)
          .AddMethod(__Method_Play, serviceImpl.Play)
          .AddMethod(__Method_Withdraw, serviceImpl.Withdraw)
          .AddMethod(__Method_Deposit, serviceImpl.Deposit)
          .AddMethod(__Method_TransferOwnership, serviceImpl.TransferOwnership)
          .AddMethod(__Method_GetPlayAmountLimit, serviceImpl.GetPlayAmountLimit)
          .AddMethod(__Method_GetContractBalance, serviceImpl.GetContractBalance)
          .AddMethod(__Method_GetOwner, serviceImpl.GetOwner).Build();
    }

  }
}
#endregion

