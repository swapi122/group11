




/*
'===============================================================================
'  LinqHelper.DAO.SoDoToChucBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqSoDoToChucBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqSoDoToChucBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqSoDoToChucEntity obj)
		{
			provider.GetTable<LqSoDoToChucEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqSoDoToChucEntity _obj)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqSoDoToChucEntity tmp = q.First<LqSoDoToChucEntity>();
			
			tmp.IdToChuc = _obj.IdToChuc;
			tmp.IdDoiTuong = _obj.IdDoiTuong;
			tmp.NgayThamGia = _obj.NgayThamGia;
			tmp.NgayRoi = _obj.NgayRoi;
			tmp.IdCha = _obj.IdCha;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.MaTp = _obj.MaTp;
			tmp.GhiChu = _obj.GhiChu;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqSoDoToChucEntity obj)
		{
			provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdToChuc(Guid IdToChuc)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.IdToChuc == IdToChuc
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.IdDoiTuong == IdDoiTuong
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayThamGia(DateTime NgayThamGia)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.NgayThamGia.Value == NgayThamGia
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayRoi(DateTime NgayRoi)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.NgayRoi.Value == NgayRoi
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdCha(Guid IdCha)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.IdCha.Value == IdCha
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaTp(string MaTp)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.MaTp == MaTp
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqSoDoToChucEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqSoDoToChucEntity ob = (LqSoDoToChucEntity)q.First<LqSoDoToChucEntity>();
            provider.GetTable<LqSoDoToChucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqSoDoToChucEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqSoDoToChucEntity>();
		}

		public List<LqSoDoToChucEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByIdToChuc(Guid IdToChuc)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.IdToChuc == IdToChuc
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByIdDoiTuong(Guid IdDoiTuong)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.IdDoiTuong == IdDoiTuong
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByNgayThamGia(DateTime NgayThamGia)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.NgayThamGia.Value == NgayThamGia
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByNgayRoi(DateTime NgayRoi)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.NgayRoi.Value == NgayRoi
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByIdCha(Guid IdCha)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.IdCha.Value == IdCha
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByMaTp(string MaTp)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.MaTp == MaTp
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		public List<LqSoDoToChucEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqSoDoToChucEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqSoDoToChucEntity>();
		}
		
		
		

	}
}
